using UnityEngine;
using System.Collections;

public class EnemyC : MonoBehaviour {



	private float speed = 10f;
	private float rotationSmooth = 1f;
<<<<<<< HEAD

=======
<<<<<<< HEAD
>>>>>>> remotes/origin/takaN
=======
>>>>>>> afdc0a601d1326741ae8335a763fe1ff013aa9cd
>>>>>>> a1324c4787b69fa88e4f947d70da93e6ba7eb2bf
	public int hp = 1;
	
	private Vector3 targetPosition;
	
	private float changeTargetSqrDistance = 40f;
	
	private void Start()
	{

		targetPosition = GetRandomPositionOnLevel();
	}
	
	private void Update()
	{

		// 目標地点との距離が小さければ、次のランダムな目標地点を設定する
		float sqrDistanceToTarget = Vector3.SqrMagnitude(transform.position - targetPosition);
		if (sqrDistanceToTarget < changeTargetSqrDistance)
		{
			targetPosition = GetRandomPositionOnLevel();
		}
		
		// 目標地点の方向を向く
		Quaternion targetRotation = Quaternion.LookRotation(targetPosition - transform.position);
		transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotationSmooth);
		
		// 前方に進む
		transform.Translate(Vector3.forward * speed * Time.deltaTime);
	}
	
	public Vector3 GetRandomPositionOnLevel()
	{
		float levelSize = 55f;
		return new Vector3(Random.Range(-levelSize, levelSize), 0, Random.Range(-levelSize, levelSize));
	}
<<<<<<< HEAD
	void OnTriggerEnter(Collider coll) {
		if (coll.gameObject.tag == "Player") {
			//Instantiate(Explosion, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
			Destroy(this.gameObject);
		}
	}
=======
<<<<<<< HEAD
>>>>>>> remotes/origin/takaN
=======
>>>>>>> afdc0a601d1326741ae8335a763fe1ff013aa9cd
>>>>>>> a1324c4787b69fa88e4f947d70da93e6ba7eb2bf
}
