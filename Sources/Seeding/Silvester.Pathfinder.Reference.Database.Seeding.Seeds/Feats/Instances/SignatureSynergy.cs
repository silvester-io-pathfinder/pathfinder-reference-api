using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SignatureSynergy : Template
    {
        public static readonly Guid ID = Guid.Parse("5a0033a2-ac76-4239-a1a3-ec6fb122ed24");

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
            yield return new TextBlock { Id = Guid.Parse("b1cffe2e-b28d-4d1b-ace6-3b7df838d6a5"), Type = TextBlockType.Text, Text = "Your eidolon gains an evolution integral to its form, and it comes more easily than your other synergies. You gain one (trait: evolution) feat from the following list: (feat: Airborne Form), (feat: Burrowing Form), (feat: Ever-Vigilant Senses), or (feat: Hulking Size). For the purpose of meeting its prerequisites, your summoner level is equal to your character level – 4." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("61fe7f14-dd39-4f4b-9f20-35981d01830d"), Feats.Instances.AdvancedSynergy.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a8cf631c-6748-487a-8f36-54ec4ff421c2"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}