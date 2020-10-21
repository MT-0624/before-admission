# coding-UTF-8

import copy
import time

'''
    引数にたびたび現れるlstについて
    [[萬子][筒子][索子][字牌]]の順に
    数牌は1~9,字牌は東南西北白發中の順に枚数が入っている
    
    例:国士無双完成形[[1,0,0,0,0,0,0,0,1][1,0, ... [1,1,1,1,1,1,2]]
'''

# 出力時日本語化する用
color_to_jap = {
    0: "萬",
    1: "筒",
    2: "索",
    3: ""
}


def is_common(lst: list) -> bool:
    if 1 in lst[3] or 4 in lst[3]:
        return False

    # 2枚以上ある牌のインデックスのリスト
    duo_lst = []

    # 字牌の対子があればそれに絞る
    if 2 in lst[3]:
        duo_lst.append((3, lst[3].index(2)))
    else:
        # 2枚以上ある数牌を雀頭候補に追加
        for i in range(0, 3):
            for j in range(0, 9):
                if lst[i][j] >= 2:
                    duo_lst.append((i, j))

    for color, number in duo_lst:
        mentu = 0
        lst_wk = copy.deepcopy(lst)

        lst_wk[color][number] -= 2

        # 字牌
        mentu += lst_wk.count(3)
        if mentu == 4:
            return True

        # それぞれの数牌でメンツをカウントしていく
        for col in range(0, 3):
            possibility = True
            i = -1
            while i < 8:
                i += 1
                if lst_wk[col][i] == 1 or lst_wk[col][i] == 2:
                    if i > 6:
                        possibility = False
                        break
                    else:
                        if lst_wk[col][i + 1] > 0 and lst_wk[col][i + 2] > 0:
                            for k in range(0, 3):
                                lst_wk[col][i + k] -= 1
                            mentu += 1
                            i -= 1
                            continue
                        else:
                            possibility = False
                            break
                if lst_wk[col][i] == 3 or lst_wk[col][i] == 4:
                    lst_wk[col][i] -= 3
                    mentu += 1
                    i -= 1

            if not possibility:
                break

            if mentu == 4:
                return True

    return False


def is7pair(lst: list) -> bool:
    s = sum([lst[i].count(2) for i in range(0, 4)])

    return s == 7


def is13orphans(lst: list) -> bool:
    # 么九牌がそれぞれ1枚以上かつ合計が14枚

    # 数牌

    for i in range(0, 3):
        lst_shp = lst[i]
        if lst_shp[0] < 1 or lst_shp[8] < 1:
            return False

    for i in range(0, 7):
        lst_ji = lst[3]
        if lst_ji[i] < 1:
            return False

    if sum(map(sum, lst)) != 14:
        return False

    return sum([l.count(2) for l in lst]) == 1


# 何を得れば上がれるかを求める関数なのでこの引数のリストは牌を引いていない状態の13枚の牌で構成される
def wait(lst: list):
    draw_lst = []
    win_lst = []

    # 数牌
    for i in range(0, 3):
        for j in range(0, 9):
            if lst[i][j] != 4:
                draw_lst.append((i, j))

    # 字牌
    for i in range(0, 7):
        if lst[3][i] != 4:
            draw_lst.append((3, i))

    # 上がれるか検証
    for color, num in draw_lst:
        hand = copy.deepcopy(lst)
        hand[color][num] += 1

        if is_common(hand) or is7pair(hand) or is13orphans(hand):
            win_lst.append((color, num))

    return win_lst


if __name__ == "__main__":
    while True:
        hand = [[0 for i in range(0, 9)] for j in range(0, 3)]
        hand.append([0 for i in range(0, 7)])

        # 固定長の個数だけの配列にする
        # 九蓮宝燈=> [3,1,1,1,2,1,1,1,3]
        print("牌を入力してください>>> ")

        for i in range(0, 13):
            color, num = [int(x) for x in input().split(" ")]
            num -= 1

            hand[color][num] += 1

        answers = wait(hand)

        print("待ち: ", end="")
        for cl, num in answers:
            print("{}{}".format(num + 1, color_to_jap[cl]), end=" ")

        print("\n")
        time.sleep(1)
