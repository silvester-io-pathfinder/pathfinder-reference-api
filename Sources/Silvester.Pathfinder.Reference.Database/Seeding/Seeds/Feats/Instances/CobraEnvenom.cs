using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CobraEnvenom : Template
    {
        public static readonly Guid ID = Guid.Parse("92232593-2607-4779-aa6d-db7f4090c6b9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cobra Envenom",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "If you have this feat, the circumstance bonus to Fortitude saves and Fortitude DC granted by Cobra Stance increases from +1 to +2.",
                Trigger = null,
                Frequency = "once per minute"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0ef7f005-ce20-4c09-accb-6fa9194390e6"), Type = TextBlockType.Text, Text = "You lash out with devious intent and the power to envenom your foe. Make a cobra fang (action: Strike). Your reach with this (action: Strike) is 5 feet greater than normal. If this (action: Strike) hits, the target takes 1d4 persistent poison damage per weapon damage die." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("557be512-8e4e-4421-b042-c5be29ab95b1"), Feats.Instances.CobraStance.ID);
            builder.HaveSpecificWeaponCategorySpecificProficiency(Guid.Parse("c4103776-11c7-43e5-93a7-461d784e5aef"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Unarmed.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("45ef1894-beee-4d10-8b77-2e58b5d52486"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
