//Input has to be set up in Unity
//There are 3 errors in this script

namespace AbilitySystem
{
    using UnityEngine;
    using AbilitySystem.Spells;
	using UnityEngine.InputSystem;

	public class Casting : MonoBehaviour
    {
		#region Variables
		//All player spells to spawn
		[SerializeField]
		private Spell primarySpellToSpawn, secondarySpellToSpawn, spellThreeToSpawn, spellFourToSpawn, ultimateToSpawn;
		//All player spells that they can use
		private Spell primarySpell, secondarySpell, spellThree, spellFour, ultimate;

		//GCD
		[SerializeField]
		private float globalCoolDownMax = 0.4f;
		private float globalCoolDown;

		#endregion

		#region Input

		//Left mouse button
		public void PrimaryInput(InputAction.CallbackContext context)
		{
			if (primarySpell != null && CanCastGCD())
			{
				if (primarySpell.Cast()) ResetGCD();
			}
			Debug.Log("Input");
		}

		//Right mouse button
		public void SecondaryInput(InputAction.CallbackContext context)
		{
			if (secondarySpell != null && CanCastGCD())
			{
				if (secondarySpell.Cast()) ResetGCD();
			}
		}

        //E
		public void SpellThreeInput(InputAction.CallbackContext context)
		{
			if (spellThree != null && CanCastGCD())
			{
				if(spellFour.Cast())ResetGCD();
			}
		}
        //F
		public void SpellFourInput(InputAction.CallbackContext context)
		{
			if (spellFour != null && CanCastGCD())
			{
				if(spellThree.Cast())ResetGCD();
			}
		}
		public void UltimateInput(InputAction.CallbackContext context)
		{
			if (ultimate != null && CanCastGCD())
			{
				if(ultimate.Cast())ResetGCD();
			}
		}
		#endregion

		#region GCD
		private bool CanCastGCD(){
			return (globalCoolDown == 0);
		}

		private void ResetGCD(){
			globalCoolDown = globalCoolDownMax;
		}

		private void ReduceGCD(){
			globalCoolDown = Mathf.Clamp(globalCoolDown - Time.deltaTime, 0, globalCoolDownMax);
		}

		#endregion


		private void Update()
		{
			ReduceGCD();
		}

		private void Start()
		{
			primarySpell = SpawnSpell(primarySpellToSpawn);
			secondarySpell = SpawnSpell(primarySpellToSpawn);
			spellThree = SpawnSpell(spellThreeToSpawn);
			spellFour = SpawnSpell(spellFourToSpawn);
			ultimate = SpawnSpell(ultimate);
		}

		private Spell SpawnSpell(Spell spellToSpawn)
		{
			if(spellToSpawn != null)
			{
				Spell spawnedSpell = Instantiate(spellToSpawn);
				spawnedSpell.transform.SetParent(this.transform);
				spawnedSpell.transform.position = this.transform.position;
				spawnedSpell.transform.rotation = this.transform.rotation;
				return spawnedSpell;
			}
			else{
				return null;
			}
		}
	}

}
