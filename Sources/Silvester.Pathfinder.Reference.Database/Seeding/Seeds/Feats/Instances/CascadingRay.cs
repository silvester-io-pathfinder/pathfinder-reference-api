using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CascadingRay : Template
    {
        public static readonly Guid ID = Guid.Parse("ddb8d9ca-be6d-4481-ba29-18e08e160a79");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cascading Ray",
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
            yield return new TextBlock { Id = Guid.Parse("77b907e8-8b26-468f-9a08-e81ce8799445"), Type = TextBlockType.Text, Text = "Magical energy spills out to extend beyond the creature you struck. The flowing energy forms a ray with a range of 60 feet from the creature you damaged. You can’t target any of the creatures you damaged with your (feat: Spellstrike) with the ray. Make a spell attack roll against the new target’s AC, at the same multiple attack penalty as the (action: Strike). On a hit, the target of the ray takes 1d4 damage per spell level of the same type of energy damage the spell deals (double damage on a critical hit). If you cast the spell in your (feat: Spellstrike) from a spell slot, the damage from Cascading Ray increases to 1d8 damage per spell level." };
            yield return new TextBlock { Id = Guid.Parse("3d3d5b96-764b-4b2d-965c-fb3c364c95b1"), Type = TextBlockType.Text, Text = "If the spell deals more than one type of energy damage, you choose only one for the ray. This ray has the (trait: attack) trait, the school and tradition traits of the original spell, and the trait matching the damage type." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("133e85e4-f2f3-4b94-a6ff-675ddfe10bed"), Feats.Instances.Spellstrike.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a01c0435-ff1a-438d-bded-47d15828146a"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
