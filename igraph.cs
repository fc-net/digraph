using System.Collections.Generic;

namespace DiGraph
{
    public interface IGraph <Vertex, Edge>
    {
        /// <summary>
        /// Adds a new vertex to the graph, if it is not already existing.
        /// </summary>
        /// <param name="vertex">The vertex to be added</param>
        /// <returns>True if and only if the vertex is successfully added.</returns>
        bool AddNode(Vertex node);

        /// <summary>
        /// Adds a collection of vertices to the graph.
        /// </summary>
        /// <param name="set">The set of vertices to be added</param>
        void AddNode(IEnumerable<Vertex> nodes);

        /// <summary>
        /// Removes the specified vertex, if existing.
        /// </summary>
        /// <param name="vertex">The vertex to be removed from the graph</param>
        /// <returns>True if and only if the vertex is successfully removed.</returns>
        bool DeleteNode(Vertex node);

        /// <summary>
        /// Removes from the graph each vertex contained in the specified set.
        /// </summary>
        /// <param name="set">The set containing vertices to be removed</param>
        void DeleteNode(IEnumerable<Vertex> nodes);

        /// <summary>
        /// Creates an edge, having a given weigth, between two vertices in the graph.
        /// </summary>
        /// <param name="v1">The departuring vertex</param>
        /// <param name="v2">The destination vertex</param>
        /// <param name="weigth">The weigth of the edge to be created</param>
        /// <returns>True if and only if the edge is created successfully.</returns>
        bool AddEdge(Vertex v1, Vertex v2, int weigth);

        /// <summary>
        /// Returns the weigth of the edge departuring from v1 and arriving to v2, if existing.
        /// </summary>
        /// <param name="v1">The departuring vertex</param>
        /// <param name="v2">The destination vertex</param>
        /// <returns>The weigth of the edge</returns>
        int GetWeight(Vertex v1, Vertex v2);

        /// <summary>
        /// Deletes the edge departuring from vertex v1 and arriving to vertex v2.
        /// </summary>
        /// <param name="v1">The departuring vertex</param>
        /// <param name="v2">The destination vertex</param>
        /// <returns>True if and only if the edge is successfully removed from the graph</returns>
        bool DeleteEdge(Vertex v1, Vertex v2);

        /// <summary>
        /// Tells whether vertex v1 is adjacent to vertex v2.
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns>True if and only if v1 is adjacent to v2</returns>
        bool AreAdjacent(Vertex v1, Vertex v2);

        /// <summary>
        /// Gets the degree of the specified vertex.
        /// </summary>
        /// <param name="vertex">The target vertex</param>
        /// <returns>An integer specifying the degree of the specified vertex</returns>
        int Degree(Vertex vertex);

        /// <summary>
        /// Gets the outgoing degree of the specified vertex.
        /// </summary>
        /// <param name="vertex">The target vertex</param>
        /// <returns>An integer specifying the outgoing degree of the specified vertex</returns>
        int OutDegree(Vertex vertex);

        /// <summary>
        /// Gets the ingoing degree of the specified vertex.
        /// </summary>
        /// <param name="vertex">The target vertex</param>
        /// <returns>An integer specifying the ingoing degree of the specified vertex</returns>
        int InDegree(Vertex vertex);

        /// <summary>
        /// Gets the number of vertices in the graph
        /// </summary>
        /// <returns>An integer representing the number of vertices in the graph</returns>
        int VertexNumber();

        /// <summary>
        /// Gets the number of edges in the graph
        /// </summary>
        /// <returns>An integer representing the number of edges in the graph</returns>
        int EdgeNumber();

        /// <summary>
        /// Retrives the set of adjacent vertices to the one specified.
        /// </summary>
        /// <param name="vertex">The target vertex</param>
        /// <returns>A set of adjacent vertices</returns>
        IEnumerable<Vertex> AdjacentVertex(Vertex node);

        /// <summary>
        /// Retrives the vertex set of the graph.
        /// </summary>
        /// <returns>The vertex set of the graph</returns>
        IEnumerable<Vertex> GetVertexSet();

        /// <summary>
        /// Retrives the edge set of the graph.
        /// </summary>
        /// <returns>The edge set of the graph</returns>
        IEnumerable<Edge<Vertex>> GetEdgeSet();
    }
}