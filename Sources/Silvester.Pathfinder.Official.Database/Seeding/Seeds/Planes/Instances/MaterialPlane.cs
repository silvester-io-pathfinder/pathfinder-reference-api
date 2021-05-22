using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Planes.Instances
{
    public class MaterialPlane : Template
    {
        public static readonly Guid ID = Guid.Parse("af0a9351-d4e7-492d-93c4-2b7ef86cfa85");

        protected override Plane GetPlane()
        {
            return new Plane 
            { 
                Id = ID, 
                CategoryId = PlaneCategories.Instances.InnerSpherePlane.ID, 
                AlignmentId = Alignments.Instances.TrueNeutral.ID, 
                Name = "Material Plane",
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("1165570b-0152-48a0-bbdc-c7b2d1318c76"), Type = TextBlockType.Text, Text = "The Material Plane is the prosaic universe and the home of mortal life. Innumerable galaxies play host to countless stars and their planets, each housing unique settings for any campaign, with Golarion as the classic example. Other worlds of note like Castrovel, Akiton, and Eox exist within Golarion’s own solar system, and then beyond this, orbiting other distant stars or in other galaxies still, worlds such as Androffa, Carcosa, and even Earth swirl within the Material Plane’s vast and silent void." };
            yield return new TextBlock { Id = Guid.Parse("dff8ed7e-d66c-49f4-bae7-1a6bcfee7c08"), Type = TextBlockType.Text, Text = "Yet for all the profound wonder and diversity of life that the Material Plane houses, in the dark places between the stars, known as the Dark Tapestry, lurk the inimical gods known as the Outer Gods and Great Old Ones, the sinister collective known as the Dominion of the Black." };
            yield return new TextBlock { Id = Guid.Parse("1737af51-a110-4ddd-b153-23eeef581f88"), Type = TextBlockType.Text, Text = "The Material Plane serves as the destination for pre-incarnate souls, each mortal life born, living, and dying before sending its spirit toward the planes of the Outer Sphere for judgment. The Material Plane is likewise the focus of the gods, each of whom is invested in fostering their own particular portfolio among mortal worshippers and the material world at large." };
        }
    }
}
