using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Knockdown : Template
    {
        public static readonly Guid ID = Guid.Parse("d47659e1-d3c3-47fc-8c1d-ae0689966aff");

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
            yield return new TextBlock { Id = Guid.Parse("c2deab48-ee8a-4169-be9d-cdc0983085c0"), Type = TextBlockType.Text, Text = "You make an attack to knock a foe off balance, then follow up immediately with a sweep to topple them. Make a melee (action: Strike). If it hits and deals damage, you can attempt an Athletics check to (action: Trip) the creature you hit. If you’re wielding a two-handed melee weapon, you can ignore (action: Trip)’s requirement that you have a hand free. Both attacks count toward your multiple attack penalty, but the penalty doesn’t increase until after you’ve made both of them." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("69b4c167-6991-45eb-98e3-ebc3199742c4"), Feats.Instances.MaulerDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("ef6604b9-aa4e-4f7d-b499-d12cb20d9bc7"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e6ad27aa-418b-4547-8464-04ec95f58e0c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
