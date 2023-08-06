using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }

        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector2(transform.position.x + _speed * Time.deltaTime * 0.7f, transform.position.y + _speed * Time.deltaTime * 0.7f);
            transform.rotation = Quaternion.Euler(0, 0, -45);
            _animator.SetBool("isMoving", true);
        }
        else if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector2(transform.position.x + _speed * Time.deltaTime * 0.7f, transform.position.y - _speed * Time.deltaTime * 0.7f);
            transform.rotation = Quaternion.Euler(0, 0, -135);
            _animator.SetBool("isMoving", true);
        }
        else if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector2(transform.position.x - _speed * Time.deltaTime * 0.7f, transform.position.y - _speed * Time.deltaTime * 0.7f);
            transform.rotation = Quaternion.Euler(0, 0, -225);
            _animator.SetBool("isMoving", true);
        }
        else if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector2(transform.position.x - _speed * Time.deltaTime * 0.7f, transform.position.y + _speed * Time.deltaTime * 0.7f);
            transform.rotation = Quaternion.Euler(0, 0, -315);
            _animator.SetBool("isMoving", true);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector2(transform.position.x - _speed * Time.deltaTime, transform.position.y);
            transform.rotation = Quaternion.Euler(0, 0, 90);
            _animator.SetBool("isMoving", true);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector2(transform.position.x + _speed * Time.deltaTime, transform.position.y);
            transform.rotation = Quaternion.Euler(0, 0, -90);
            _animator.SetBool("isMoving", true);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + _speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            _animator.SetBool("isMoving", true);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - _speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0, 0, -180);
            _animator.SetBool("isMoving", true);
        }
        else if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = new Vector2(transform.position.x + _speed * Time.deltaTime * 0.7f, transform.position.y + _speed * Time.deltaTime * 0.7f);
            transform.rotation = Quaternion.Euler(0, 0, -45);
            _animator.SetBool("isMoving", true);
        }
        else if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = new Vector2(transform.position.x + _speed * Time.deltaTime * 0.7f, transform.position.y - _speed * Time.deltaTime * 0.7f);
            transform.rotation = Quaternion.Euler(0, 0, -135);
            _animator.SetBool("isMoving", true);
        }
        else if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = new Vector2(transform.position.x - _speed * Time.deltaTime * 0.7f, transform.position.y - _speed * Time.deltaTime * 0.7f);
            transform.rotation = Quaternion.Euler(0, 0, -225);
            _animator.SetBool("isMoving", true);
        }
        else if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = new Vector2(transform.position.x - _speed * Time.deltaTime * 0.7f, transform.position.y + _speed * Time.deltaTime * 0.7f);
            transform.rotation = Quaternion.Euler(0, 0, -315);
            _animator.SetBool("isMoving", true);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = new Vector2(transform.position.x + _speed * Time.deltaTime, transform.position.y);
            transform.rotation = Quaternion.Euler(0, 0, -90);
            _animator.SetBool("isMoving", true);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = new Vector2(transform.position.x - _speed * Time.deltaTime, transform.position.y);
            transform.rotation = Quaternion.Euler(0, 0, 90);
            _animator.SetBool("isMoving", true);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + _speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            _animator.SetBool("isMoving", true);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - _speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0, 0, -180);
            _animator.SetBool("isMoving", true);
        }
        else
        {
            _animator.SetBool("isMoving", false);
        }
    }
}