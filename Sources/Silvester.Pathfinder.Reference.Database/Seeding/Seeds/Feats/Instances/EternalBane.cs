using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EternalBane : Template
    {
        public static readonly Guid ID = Guid.Parse("b6ad76cc-26af-437a-b1de-bf8ffc8d18b1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eternal Bane",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a4c2456e-7142-40f8-bdf6-07e7074e1c9a"), Type = TextBlockType.Text, Text = "A life of evil has made you a nexus for your deity’s vile power. You’re continuously surrounded by a (spell: bane) spell with a spell level equal to half your level (rounded up). The radius is 15 feet, and you can’t increase it. You can (action: Dismiss) the spell; if you do, it returns automatically after 1 minute." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("a25c7636-0918-46a8-a82b-6cef4a95c287"), or => 
            {
                or.HaveSpecificAlignment(Guid.Parse("043ffbce-eb3a-4d58-8aec-d9513d545c44"), Alignments.Instances.LawfulEvil.ID);
                or.HaveSpecificAlignment(Guid.Parse("a2fa0172-0296-4295-b2a3-f6071c9c7955"), Alignments.Instances.NeutralEvil.ID);
                or.HaveSpecificAlignment(Guid.Parse("3af0774b-7299-4cb3-b5f6-0736c525091d"), Alignments.Instances.ChaoticEvil.ID);
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
                Id = Guid.Parse("b1972793-5802-4adf-8c01-30108b2d5f0e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
