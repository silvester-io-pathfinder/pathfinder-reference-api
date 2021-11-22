using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Knockdown : Template
    {
        public static readonly Guid ID = Guid.Parse("ff04a6da-f50f-40e3-8487-bc09e12c2c48");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Knockdown",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("57872c27-608c-4515-861e-68b7888cfdc5"), Type = TextBlockType.Text, Text = "You make an attack to knock a foe off balance, then follow up immediately with a sweep to topple them. Make a melee (action: Strike). If it hits and deals damage, you can attempt an Athletics check to (action: Trip) the creature you hit. If you're wielding a two-handed melee weapon, you can ignore (action: Trip)'s requirement that you have a hand free. Both attacks count toward your multiple attack penalty, but the penalty doesn't increase until after you've made both of them." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1ed0c574-6fcb-4dff-a0e3-ce2a39626190"), Feats.Instances.MaulerDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("ee9f85e2-b44b-4e78-98ac-b8a93b25392b"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a05b579e-b8ec-477c-9eb9-23b6384befbd"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
