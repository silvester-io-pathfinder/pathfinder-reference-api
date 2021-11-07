using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HalflingWeaponTrickster : Template
    {
        public static readonly Guid ID = Guid.Parse("ea34a0ac-3d73-459e-be8b-e55b3f50e30c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Halfling Weapon Trickster",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c2719c64-caf4-44a6-b964-0b0da5068e63"), Type = TextBlockType.Text, Text = "You are particularly adept at fighting with your people’s favored weapons. Whenever you critically succeed at an attack roll using a shortsword, a sling, or a halfling weapon, you apply the weapon’s critical specialization effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("26524ca3-43a0-48cf-963e-bb8028631223"), Feats.Instances.HalflingWeaponFamiliarity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ce0110fe-bdc8-43b8-9c7f-58f3ea768344"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
