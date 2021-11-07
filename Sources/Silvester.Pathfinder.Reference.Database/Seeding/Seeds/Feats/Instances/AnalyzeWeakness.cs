using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AnalyzeWeakness : Template
    {
        public static readonly Guid ID = Guid.Parse("0b461b6c-bbef-4876-aaf2-e483d4ed19c1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Analyze Weakness",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a6921e36-b4ba-486b-aae3-4690e9cff2d2"), Type = TextBlockType.Text, Text = "Your knowledge of a creature’s physiology and understanding of tactics helps you attack with pinpoint accuracy. You carefully study a creature that you’ve identified to scope out particularly weak points in its positioning or physical form. The next time you deal sneak attack damage to the chosen creature with a (action: Strike) before the end of your turn, add an additional 2d6 precision damage. At 11th and 17th levels, if your additional damage from sneak attack increases, increase the additional damage from Analyze Weakness to 3d6 at 11th level and 4d6 at 17th level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClass(Guid.Parse("6fbf32ec-a127-4a86-b748-17c52cedd0a0"), Classes.Instances.Rogue.ID);
            builder.HaveSpecificLevel(Guid.Parse("fa205093-f24a-451d-9c69-97402fb88201"), Comparatos.GreaterThanOrEqualTo, level: 5);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("20a019cb-e932-4f9e-92b7-47b86258ec09"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
