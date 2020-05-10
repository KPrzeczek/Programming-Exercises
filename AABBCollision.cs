/*
** Box Colliders are literally just an XNA Rectangle along with a position.
** I wanted to post this code to help out to anyone working on basic AABB
** Collision Resolution since personally I can't stand it and is the one 
** thing I love and hate about monogame. It works and doesn't require you 
** to use an overkill physics engine capable of handling complex rotation 
** factors and SAT Collision resolution, something many people recommended I use.
** It should be fairly trivial to port to any other programming language.

** NOTE: This is STATIC collision resolution. Not something like impulse
** that responds with a realistic velocity bounce-off. This literally just 
** stops/moves back the AA Rectangle to a point so that it doesn't collide

** Good luck, have fun!
*/

public static bool ShapeOverlap_AABB(BoxCollider r1, BoxCollider r2)
{
    var b1 = r1.Rectangle;
    var b2 = r2.Rectangle;

    float halfW1 = b1.Width / 2f;
    float halfH1 = b1.Height / 2f;

    float halfW2 = b2.Width / 2f;
    float halfH2 = b2.Height / 2f;

    return (
        r1.Position.X - halfW1 < r2.Position.X + halfW2 &&
        r1.Position.X + halfW1 > r2.Position.X - halfW2 &&
        r1.Position.Y - halfH1 < r2.Position.Y + halfH2 &&
        r1.Position.Y + halfH1 > r2.Position.Y - halfH2
    );
}

public static bool ShapeOverlap_AABB_STATIC(BoxCollider r1, BoxCollider r2)
{
    if(ShapeOverlap_AABB(r1, r2))
    {
        Vector2 restingDistance = new Vector2(
            r1.Rectangle.Width  / 2 + r2.Rectangle.Width / 2,
            r1.Rectangle.Height / 2 + r2.Rectangle.Height / 2
        );

        Vector2 currentDistance = new Vector2(
            r1.Position.X - r2.Position.X,
            r1.Position.Y - r2.Position.Y
        );

        Vector2 overlap = new Vector2(
            restingDistance.X - Math.Abs(currentDistance.X),
            restingDistance.Y - Math.Abs(currentDistance.Y)
        );

        overlap = new Vector2(
            overlap.X < overlap.Y ? overlap.X : 0,
            overlap.Y < overlap.X ? overlap.Y : 0
        );

        overlap = new Vector2(
            r1.Position.X < r2.Position.X ? -overlap.X : overlap.X,
            r1.Position.Y < r2.Position.Y ? -overlap.Y : overlap.Y
        );

        r1.Parent.Position += overlap;
    }

    return false;
}