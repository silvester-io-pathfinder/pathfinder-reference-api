using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InstinctiveStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("1f9fa91e-1ad5-414c-810b-8ff4d11fad3f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Instinctive Strike",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("28c2d073-9a55-4e19-99a8-7dc9ebc2701d"), Type = TextBlockType.Text, Text = "You trust your instincts and your sense of smell, using all of your senses to pinpoint your opponent's location. Make a melee (action: Strike) against an opponent that isn't hiding its scent with an effect like (spell: negate aroma). This attack ignores any flat check required due to the target being concealed or hidden." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("21f8dfc5-f0a5-42a8-a61c-d6f9cc6bbfc6"), or => 
            {
                or.HaveSpecificFeat(Guid.Parse("dbbb5302-4fc8-4627-92e0-9c95e9fc33bf"), Feats.Instances.AcuteScent.ID);
                or.HaveSpecificSense(Guid.Parse("3692f5c1-bfa4-4f5d-ae67-08399a09ea49"), Senses.Instances.Scent.ID);
                or.HaveSpecificSense(Guid.Parse("2e75a02d-cd57-4e38-90fe-de4e6b2d0946"), Senses.Instances.Scent.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dfb23336-fafd-4454-b396-f668311184c7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
