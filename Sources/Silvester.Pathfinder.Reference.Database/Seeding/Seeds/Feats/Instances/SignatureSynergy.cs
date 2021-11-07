using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SignatureSynergy : Template
    {
        public static readonly Guid ID = Guid.Parse("47319077-29ad-49ba-a640-0fd780f57d3c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Signature Synergy",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fdb29571-81f2-44ab-b799-236cf29a58f0"), Type = TextBlockType.Text, Text = "Your eidolon gains an evolution integral to its form, and it comes more easily than your other synergies. You gain one (trait: evolution) feat from the following list: (feat: Airborne Form), (feat: Burrowing Form), (feat: Ever-Vigilant Senses), or (feat: Hulking Size). For the purpose of meeting its prerequisites, your summoner level is equal to your character level – 4." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("3ffd3a82-13a0-474f-a98d-3cb361accdac"), Feats.Instances.AdvancedSynergy.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e19f5350-9917-4210-8fc7-4d3f05784a92"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
