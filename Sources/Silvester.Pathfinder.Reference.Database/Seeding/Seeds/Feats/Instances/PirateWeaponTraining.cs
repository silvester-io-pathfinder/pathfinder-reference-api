using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PirateWeaponTraining : Template
    {
        public static readonly Guid ID = Guid.Parse("0276ae28-951a-49c6-b7c3-dbe0906f4a9f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pirate Weapon Training",
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
            yield return new TextBlock { Id = Guid.Parse("7d3c0d78-f92c-4d39-9bb6-ea209a44b193"), Type = TextBlockType.Text, Text = "You’re particularly skilled at wielding traditional pirate weapons. You become trained with the following weapons: (item: hatchet), (item: rapier), (item: scimitar), and (item: whip). Whenever you gain a class feature that grants you expert or greater proficiency with a given weapon or weapons, you also gain that proficiency rank for these weapons." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("8f101650-1d62-49e6-8942-39843a6130f7"), Feats.Instances.PirateDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("85a69c0e-5eb2-405b-ad52-fca3ca75b48d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
