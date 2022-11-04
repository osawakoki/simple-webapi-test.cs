internal static class Index
{
  internal static IResult index_get()
  {
    return Results.Ok(new
    {
      comment = "Hello World",
      message = "Wolcome to MinimalAPI test unit!!!",
    });
  }
}

