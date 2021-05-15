using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Forword : MonoBehaviour
{
    // �Q��
    public Player_State sc_state;
    public Player sc_move;

    // �ϐ�
    GameObject m_Block = null;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        sc_state.Set_CanClimb_Forword(true);
        if (other.gameObject.tag == "Block")
        {
            sc_state.Set_IsBlock(true);
            m_Block = other.gameObject;
        }
        if (other.gameObject.tag == "Stage")
        {
            sc_state.Set_IsStage(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        sc_state.Set_CanClimb_Forword(false);

        sc_state.Set_IsBlock(false);
        sc_state.Set_IsStage(false);
    }

    public GameObject Get_Block()
    {
        return m_Block;
    }
}
