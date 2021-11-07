using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SummonFiendishKin : Template
    {
        public static readonly Guid ID = Guid.Parse("6b4193da-eab9-4a2f-9bed-a6dece2a8236");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Summon Fiendish Kin",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("61904606-02eb-4391-9657-d501c0bb1511"), Type = TextBlockType.Text, Text = "You have a deep connection to the fiendish realms, allowing you to summon a fiend matching your own lineage. Once per day, you can cast (spell: summon fiend) as a 5th-level divine innate spell. The fiend you summon must match your own lineage." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificAncestry(Guid.Parse("19a7e834-195a-4658-9ade-8eb3724db623"), Ancestries.Instances.Tiefling.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d48db146-5b1e-4678-bc34-0c48ed8ef342"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
