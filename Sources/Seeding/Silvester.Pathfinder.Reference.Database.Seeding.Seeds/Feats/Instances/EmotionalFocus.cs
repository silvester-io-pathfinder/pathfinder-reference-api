using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EmotionalFocus : Template
    {
        public static readonly Guid ID = Guid.Parse("943e60a3-ae4b-4d99-92d2-63619555f14e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Emotional Focus",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3bf49d73-0c97-4faf-b2d7-c994d43c930c"), Type = TextBlockType.Text, Text = "Some emotional states, such as love or hatred, require the caster to focus on a specific individual called their emotional focus. Your emotional focus can change over time with you choosing a new focus after an important part of your story is resolved. Work with your GM to determine when this change happens. An emotional focus doesn't get a say in the matter; the cathartic spellcaster's emotions determine the bond. However, making another PC your emotional focus could result in an uncomfortable social dynamic. You should check with that PC's player in advance to see if such a link is acceptable." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("23c69d45-a31c-4293-a952-78164f85355f"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
