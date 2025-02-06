//There are no errors in this script

namespace AbilitySystem.Spells
{
	using UnityEngine;
	public class PeaShooter : Spell
    {
		[SerializeField]
		private Bullet bullet; 
		public override bool Cast()
		{
			if(bullet != null){
				Bullet spawnedBullet = Instantiate(bullet);
				spawnedBullet.transform.position = this.transform.position;
				//TODO: Get mouse position and assign rotation of bullet
				spawnedBullet.transform.rotation = this.transform.rotation;
				return true;
			}
			else{
				return false;
			}
		}
	}
}
