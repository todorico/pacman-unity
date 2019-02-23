
using System.Collections;
using System.Security.Policy;
/// <summary>
///  objet noyaux don découle toute mes autres classes
/// </summary>
public class objetMere
{
	/// <summary>
	///  coordonées
	/// </summary>
	protected float _x;
	protected float _y;

	/// <summary>
	///  constructeur par défaut.
	/// </summary>
	public objetMere(){
		this.setX (0);
		this.setY (0);
	}

	public objetMere(float x , float y){
		this.setX (x);
		this.setY (y);
	}



	/// <summary>
	///  accesseur en lecture
	/// </summary>
	public float getX(){
		return _x;
		}

	public float getY(){
		return _y;
	}

	/// <summary>
	///  accesseur en ecriture
	/// </summary>
	public void setX(float x){
		_x = x;
	}

	public void setY(float y){
		_y= y;
	}
}