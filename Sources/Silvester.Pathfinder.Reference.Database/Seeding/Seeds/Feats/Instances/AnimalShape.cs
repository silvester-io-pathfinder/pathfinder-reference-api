using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AnimalShape : Template
    {
        public static readonly Guid ID = Guid.Parse("161ca3bd-b569-42c6-92e3-75dbc0078607");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Animal Shape",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ef9dfbc1-a9e4-4f98-92ce-841500382ea3"), Type = TextBlockType.Text, Text = "You have full control over your shape and can transform into your inherent animal. You can use (feat: Change Shape | Change Shape - Beastkin) to enter an animal shape. When you gain this feat, choose either (spell: aerial form), (spell: animal form), or (spell: dinosaur form); after you choose a form, you can’t change the form. While in animal shape, you gain the effects of a 5th-level casting of your chosen form spell, except you always transform into an animal matching your inherent animal and can use your humanoid form’s AC if it’s higher than what the animal form grants. If your inherent animal isn’t among the animals listed in the form, you default to the statistics and abilities of the bird battle form, cat battle form, or deinonychus battle form for (spell: aerial form), (spell: animal form), and (spell: dinosaur form), respectively (at the GM’s discretion, you instead default to a different form that is closest to your inherent animal). You can remain in animal shape indefinitely and can use (feat: Change Shape | Change Shape - Beastkin) to return to your humanoid or hybrid shape at any time." };
            yield return new TextBlock { Id = Guid.Parse("01f2aaa5-e254-4e55-9545-1cf7463b62d6"), Type = TextBlockType.Text, Text = "If you have the (feat: Critter Shape) feat, you can choose to gain the effects of a 4th-level (spell: pest form), can remain in critter shape indefinitely, and can return to your critter shape at any time after leaving the shape, just as you can with Animal Shape." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("77aaca22-ed66-4dc9-8edb-3804ba4a46bc"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
