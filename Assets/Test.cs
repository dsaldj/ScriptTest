using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {

    // 体力
    private int hp = 100;
    // 攻撃力
    private int power = 25;
    //魔力
    private int mp = 53;


    int[] array = { 1, 2, 3, 4, 5 };

    // 攻撃用の関数
    public void Attack() {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage) {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

    //魔法攻撃用
    public void Magic() {
        if (mp > 5) {
            mp -= 5;
            Debug.Log("魔法攻撃した。残りMPは" + mp + "。");
        }
        else {
            Debug.Log("MPが足りない。");
        }
    }
}

    public class Test : MonoBehaviour{
    

    // Start is called before the first frame update
    void Start()
    {
        //要素の個数が5の、int型の配列array
        int[] array = { 1, 2, 3, 4, 5 };

        //for文を使い、配列の各要素の値を順番に表示
        for (int i = 0; i < 5; i++) {
            Debug.Log(array[i]);
        }

        //for文を使い、配列の各要素の値を逆順に表示
        for (int i = 4; i >= 0; i--) {
            Debug.Log(array[i]);
        }

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);

        //魔法攻撃用の関数を呼び出す
        for (int i = 0; i < 10; i++) {
            lastboss.Magic();
        }
        //10回呼び出した後、MPが足りないことの確認
        lastboss.Magic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
