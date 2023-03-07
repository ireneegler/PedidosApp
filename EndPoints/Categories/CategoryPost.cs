﻿using PedidosApp.Infra.Data;

namespace PedidosApp.EndPoints.Categories;

public class CategoryPost
{
    public static string Template => "/categories";
    public static string[] Methods => new string[] { HttpMethod.Post.ToString() };
    public static Delegate Handle => Action;

    public static IResult Action(CategoryRequest categoryRequest, ApplicationDbContext context)
    {
        return Results.Ok("Ok");
    }
}

