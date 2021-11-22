using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ClansEdge : Template
    {
        public static readonly Guid ID = Guid.Parse("e63c506c-fe4a-4831-86e3-6a0f9100add4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Clan's Edge",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("79bf7e6b-4046-48b2-9548-15c2fecf7164"), Type = TextBlockType.Text, Text = "By moving your clan dagger with rapid precision, you can protect yourself more effectively. Make two (item: clan dagger) (action: Strikes | Strike) against different targets. Your multiple attack penalty applies normally to these (action: Strikes | Strike). You then use an (action: Interact) action to gain the +1 circumstance bonus to your AC from your clan dagger's (trait: parry) trait." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMeleeWeaponSpecificProficiency(Guid.Parse("4431a7c7-868f-4105-9333-3d2b27cb79f0"), Proficiencies.Instances.Trained.ID, MeleeWeapons.Instances.ClanDagger.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fbad6956-03da-49bd-9e50-9ead6f467e0b"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
