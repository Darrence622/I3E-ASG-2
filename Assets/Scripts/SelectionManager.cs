using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    [SerializeField] private string selectableTag = "Selectable";
    [SerializeField] private Material highlightMaterial;
    [SerializeField] private Material defaultMaterial;

    private Transform _selection;
    public Transform placeHolder;

    public static bool findBook = false;
    private bool detected = false;
    public static bool findJesus = false;

    private void Start()
    {
        findBook = false;
        findJesus = false;
    }


    private void Update()
    {
        if (_selection != null)
        {
            var selectionRenderer = _selection.GetComponent<Renderer>();
            selectionRenderer.material = defaultMaterial;
            _selection = null;
        }

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 3))
        {
            var selection = hit.transform;
            if (selection.CompareTag(selectableTag))
            {
                var selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    selectionRenderer.material = highlightMaterial;
                }
                _selection = selection;
                Debug.Log(_selection);
                detected = true;
            }

            if (detected == true)
            {
                if (selection.name == "book")
                {
                    findBook = true;
                }

            if (detected==true)
                {
                    if (selection.name=="jesus")
                    {
                        findJesus = true;
                    }    
                }    




            }

        }
    }
}
