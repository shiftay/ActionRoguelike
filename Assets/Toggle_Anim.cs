using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEditor.Animations;
using UnityEngine;

public enum Effects { BITE = 0, IMPACT, LIGHTNING_AURA, MAGIC_SPAWN, SMOKE_BOMB, SPLATTER, TOON, WARP }
public enum Spells { ABSORB = 0, FIRESPELL, WINDSPELL, ICESPELL, SHATTER, LIGHTNING, CLAW, EARTHSPIKES, POISON }
public enum Projectiles { DEFAULT = 0, FIREBALL, SHOCKWAVE, HELIXBEAM, MAGICMISSILE, MISSILE, SHURIKEN, METEOR, LIGHTNINGORB, KUNAI, ICESPIKE }

public class Toggle_Anim : MonoBehaviour
{
    public Animator animator;
    [HorizontalGroup("Enums")]
    [VerticalGroup("Enums/Column1")]
    public Effects currentEffect;
    [VerticalGroup("Enums/Column2")]
    public Spells currentSpell;
    [VerticalGroup("Enums/Column3")]
    public Projectiles currentProjectile;

    public AnimatorController effectAnim, spellAnim, projectileAnim;

    [HorizontalGroup("Buttons1")]
    [VerticalGroup("Buttons1/Column1")]
    [Button("Play Effect")]
    public void PlayEffect() {
        animator.runtimeAnimatorController = effectAnim;
        animator.SetTrigger(currentEffect.ToString());
    }
    [VerticalGroup("Buttons1/Column2")]
    [Button("Play Spell")]
    public void PlaySpell() {
        animator.runtimeAnimatorController = spellAnim;
        animator.SetTrigger(currentSpell.ToString());
    }
    
    [HorizontalGroup("Buttons2")]

    [VerticalGroup("Buttons2/Column1")]
    [Button("Play Proj")]
    public void PlayProj() {
        animator.runtimeAnimatorController = projectileAnim;
        animator.SetTrigger(currentProjectile.ToString());
    }
    [VerticalGroup("Buttons2/Column2")]
    [Button("Reset Proj")]
    public void ResetProj() {
        animator.SetTrigger(Projectiles.DEFAULT.ToString());
    }
}
