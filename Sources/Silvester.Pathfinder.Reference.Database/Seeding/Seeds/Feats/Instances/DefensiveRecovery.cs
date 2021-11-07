using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DefensiveRecovery : Template
    {
        public static readonly Guid ID = Guid.Parse("28a6ac18-1bcf-47c4-b6e0-33a58d1c2ee9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Defensive Recovery",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f714a10c-b26c-4bec-a4b8-daca1f7504c3"), Type = TextBlockType.Text, Text = "Your faith provides temporary protection in addition to healing. If the next action you use is to cast (spell: harm) or (spell: heal) on a single target and the target regains Hit Points from the spell, it also gains a +2 status bonus to AC and saving throws for 1 round." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("2f925ec1-cff0-400f-b320-d655c2f6b754"), or => 
            {
                or.HaveSpecificDivineFont(Guid.Parse("9de148c9-0511-45b8-859e-6dfd4cd79988"), DivineFonts.Instances.Heal.ID);
                or.HaveSpecificDivineFont(Guid.Parse("163ba122-7e2e-457b-bb63-f691c5619cfe"), DivineFonts.Instances.Harm.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4a56c0ec-b4b8-424c-97fd-7911bba22c00"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
