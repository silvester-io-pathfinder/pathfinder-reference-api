using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ClansEdge : Template
    {
        public static readonly Guid ID = Guid.Parse("d601e78d-3964-4745-8309-708b63e1c7da");

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
            yield return new TextBlock { Id = Guid.Parse("b155e837-13bd-4db0-8584-30661b359124"), Type = TextBlockType.Text, Text = "By moving your clan dagger with rapid precision, you can protect yourself more effectively. Make two (item: clan dagger) (action: Strikes | Strike) against different targets. Your multiple attack penalty applies normally to these (action: Strikes | Strike). You then use an (action: Interact) action to gain the +1 circumstance bonus to your AC from your clan dagger’s (trait: parry) trait." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMeleeWeaponSpecificProficiency(Guid.Parse("e39f8475-0db3-4bd0-85ff-142fdf3ab5d7"), Proficiencies.Instances.Trained.ID, MeleeWeapons.Instances.ClanDagger.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fa11e268-62ed-4601-b811-be3daf34b267"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
