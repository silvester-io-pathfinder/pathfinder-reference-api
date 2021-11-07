using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BloodlettingClaws : Template
    {
        public static readonly Guid ID = Guid.Parse("1d76a680-4b2f-489d-85bb-73e6155b5332");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bloodletting Claws",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d772d181-5841-4be5-a513-c9bb35abd8f0"), Type = TextBlockType.Text, Text = "Your eidolon inflicts bleeding wounds on a telling blow. If your eidolon critically hits with a melee unarmed (action: Strike) that deals slashing or piercing damage, its target takes 1d6 persistent bleed damage. Your eidolon gains an item bonus to this bleed damage equal to the unarmed attack’s item bonus to attack rolls. This is a critical specialization effect." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b9dda817-a587-483d-aa51-820a07de094e"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
