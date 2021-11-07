using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class IntuitiveIllusions : Template
    {
        public static readonly Guid ID = Guid.Parse("51f774dd-e280-49b0-82ca-eca2a3578b83");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Intuitive Illusions",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "Your turn begins.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("354aad7a-2fc8-42bb-bef7-55d47e79b55e"), Type = TextBlockType.Text, Text = "Illusion magic comes to you so naturally that you can effortlessly sustain your magical ruses. You immediately gain the effects of a (action: Sustain a Spell) action to extend the duration of one of your active illusion spells." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("51dbc6f7-8b0f-4414-8610-f736564a0ae4"), Feats.Instances.IllusionSense.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e8d8e32e-9597-4725-bcd5-bf0a069c8813"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
