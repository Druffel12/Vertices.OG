using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vertices : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        var filter = GetComponent<MeshFilter>();
        var mesh = new Mesh();
        filter.mesh = mesh;

        //Vertices
        //locations of vertices
        var verts = new Vector3[18];

        //Defining verts positions
        verts[0] = new Vector3(0, 0, 0);
        verts[1] = new Vector3(1, 0, 0);
        verts[2] = new Vector3(0, 4, 0);
        verts[3] = new Vector3(1, 4, 0);
        verts[4] = new Vector3(-0.5f, 3, 0);
        verts[5] = new Vector3(1.5f, 3, 0);
        verts[6] = new Vector3(0.5f, 4.3f, 0);
        verts[7] = new Vector3(-0.5f, 0.3f, 0);
        verts[8] = new Vector3(-0.5f, -0.52f, 0);
        verts[9] = new Vector3(-1, 0, 0);
        verts[10] = new Vector3(-1.3f, -0.5f, 0);
        verts[11] = new Vector3(-1, -1, 0);
        verts[12] = new Vector3(-0.5f, -1.3f, 0);
        verts[13] = new Vector3(0, -1, 0);
        verts[14] = new Vector3(0.3f, -0.5f, 0);

        mesh.vertices = verts;

        //Indices
        //determines which vertices make up an individual triangle
        var indices = new int[39];

        indices[0] = 0;
        indices[1] = 2;
        indices[2] = 1;

        //top trinagle
        indices[3] = 3;
        indices[4] = 1;
        indices[5] = 2;

        //top left
        indices[6] = 4;
        indices[7] = 2;
        indices[8] = 5;

        //top right
        indices[9] = 5;
        indices[10] = 4;
        indices[11] = 3;

        //top point 
        indices[12] = 6;
        indices[13] = 3;
        indices[14] = 2;

        //top bot left
        indices[15] = 7;
        indices[16] = 0;
        indices[17] = 8;

        //upper mid bot left
        indices[18] = 9;
        indices[19] = 7;
        indices[20] = 8;

        //mid mid bot left
        indices[21] = 10;
        indices[22] = 9;
        indices[23] = 8;

        //lower mid bot left
        indices[24] = 11;
        indices[25] = 10;
        indices[26] = 8;

        //bot left bot left
        indices[27] = 12;
        indices[28] = 11;
        indices[29] = 8;

        //bot right bot left
        indices[30] = 13;
        indices[31] = 12;
        indices[32] = 8;

        //right bot left
        indices[33] = 14;
        indices[34] = 13;
        indices[35] = 8;

        //upper right bot left
        indices[36] = 9;
        indices[37] = 1;
        indices[38] = 12;

        

        mesh.triangles = indices;

        //normals
        //describes how light bounces off the surface (at the vertex level)
        var norms = new Vector3[8];

        norms[0] = -Vector3.forward;
        norms[1] = -Vector3.forward;
        norms[2] = -Vector3.forward;
        norms[3] = -Vector3.forward;
        norms[4] = -Vector3.forward;

        mesh.normals = norms;

        //UVs, STs
        //defines how textures are mapped onto the surface
        var UVs = new Vector2[18];

        UVs[0] = new Vector2(0, 0);
        UVs[1] = new Vector2(1, 0);
        UVs[2] = new Vector2(0, 4);
        UVs[3] = new Vector2(1, 4);
        UVs[4] = new Vector2(-0.5f, 3);
        UVs[5] = new Vector2(1.5f, 3);
        UVs[6] = new Vector2(0.5f, 4.3f);
        UVs[7] = new Vector2(-0.5f, 0.3f);
        UVs[8] = new Vector2(-0.5f, -0.52f);
        UVs[9] = new Vector2(-1, 0);

        mesh.uv = UVs;
    }  
    

        
	// Update is called once per frame
	void OnDrawGizmos()
    {
        foreach (Vector3 vert in GetComponent<MeshFilter>().mesh.vertices)
        {
            Gizmos.DrawWireSphere(transform.position + vert, .1f);
        }
    }
}
