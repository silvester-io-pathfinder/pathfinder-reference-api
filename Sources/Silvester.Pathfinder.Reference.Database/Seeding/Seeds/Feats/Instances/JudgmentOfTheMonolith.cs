using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class JudgmentOfTheMonolith : Template
    {
        public static readonly Guid ID = Guid.Parse("695f482a-9f5e-47ae-88f4-343b07102f1c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Judgment of the Monolith",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("31f80044-70aa-4b69-bc64-dad69ae8f2a7"), Type = TextBlockType.Text, Text = "You can use the oaths bound in your ka stone to compel the truth from the living and the dead. You can activate your ka stone to target a single living creature, causing that creature to experience the effects of being in a (spell: zone of truth). You can also activate it with a 10-minute activation (envision) to cast (spell: talking corpse)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("afde1b46-8e30-4316-90f8-8208e4025928"), Feats.Instances.KaStoneRitual.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f2c98a18-a252-4bfa-9853-195ce4a97b55"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
