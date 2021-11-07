using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HeroicRecovery : Template
    {
        public static readonly Guid ID = Guid.Parse("d8781cc6-78e1-40e6-8048-76d12665b288");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Heroic Recovery",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("af1a3c08-b356-471a-aebb-b743d64204c3"), Type = TextBlockType.Text, Text = "The restorative power of your healing invigorates the recipient. If the next action you use is to cast (spell: heal) targeting a single living creature and the target regains Hit Points from the spell, it also gains three bonuses until the end of its next turn: a +5-foot status bonus to its Speed, a +1 status bonus to attack rolls, and a +1 status bonus to damage rolls." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineFont(Guid.Parse("2d4d2fe1-f676-4020-bf45-89262625e1c8"), DivineFonts.Instances.Heal.ID);
            builder.AddOr(Guid.Parse("e6b9b1d3-0acf-4c2a-9f07-eeb6feb1874a"), or => 
            {
                or.HaveSpecificAlignment(Guid.Parse("59d46a9d-9a1c-4bf0-a821-557ad4d4e25c"), Alignments.Instances.LawfulGood.ID);
                or.HaveSpecificAlignment(Guid.Parse("f9265113-b4ae-46a0-9e24-527d424f4629"), Alignments.Instances.ChaoticGood.ID);
                or.HaveSpecificAlignment(Guid.Parse("18d8f08f-95cf-4814-9dfb-1ca67669307d"), Alignments.Instances.NeutralGood.ID);
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
                Id = Guid.Parse("04492975-b6d3-4f38-8d9d-c450e1ca8838"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
