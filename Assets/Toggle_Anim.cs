using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEditor.Animations;
using UnityEngine;

public enum Effects { BITE = 0, IMPACT, LIGHTNING_AURA, MAGIC_SPAWN, SMOKE_BOMB, SPLATTER, TOON, WARP }
public enum Spells { ABSORB = 0, FIRESPELL, WINDSPELL, ICESPELL, SHATTER, LIGHTNING, CLAW, EARTHSPIKES, POISON }

public class Toggle_Anim : MonoBehaviour
{
    public Animator animator;
    public Effects currentEffect;
    public Spells currentSpell;

    public AnimatorController effectAnim, spellAnim;

    [Button("Play Effect")]
    public void PlayEffect() {
        animator.runtimeAnimatorController = effectAnim;
        animator.SetTrigger(currentEffect.ToString());
    }

    [Button("Play Spell")]
    public void PlaySpell() {
        animator.runtimeAnimatorController = spellAnim;
        animator.SetTrigger(currentSpell.ToString());
    }
}
