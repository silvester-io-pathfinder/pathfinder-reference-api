using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TetraelementalAssault : Template
    {
        public static readonly Guid ID = Guid.Parse("44bbfce6-48fb-45f1-9192-66a3ac3a93f8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tetraelemental Assault",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d99cd190-605d-4bee-a828-c8399f4f896c"), Type = TextBlockType.Text, Text = "Your (feat: Elemental Assault) cycles through all four elements. When you use (feat: Elemental Assault), instead of choosing a single element, you can choose an element from the list when using the action, and then choose a different element at the beginning of each of your next 3 turns without spending an action; once you have chosen an element, you can’t choose it again during this (feat: Elemental Assault), meaning you must select all four elements over the course of 4 turns." };
            yield return new TextBlock { Id = Guid.Parse("ec68f66b-c1ae-428d-b395-ea4b44165093"), Type = TextBlockType.Text, Text = "Each time you choose an element, until the beginning of your next turn, your (action: Strikes | Strike) deal an additional 1d6 damage of the indicated type and have the trait corresponding to that element." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("9674c131-44c7-4d8e-a0e3-ba62291a885e"), Feats.Instances.ElementalAssault.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b2d5d399-cff2-4926-9f56-ce5e608ebb87"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
