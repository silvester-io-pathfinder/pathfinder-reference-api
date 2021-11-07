using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SongOfTheFallen : Template
    {
        public static readonly Guid ID = Guid.Parse("cc0ca6d6-d19e-4dc8-9718-158d6db20e59");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Song of the Fallen",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("466dc11d-551e-49ca-a2e8-dbe53b897a10"), Type = TextBlockType.Text, Text = "~ Access: secure Visitor’s Pins or an alliance with Mengkare." };
            yield return new TextBlock { Id = Guid.Parse("ac43c147-fb4a-4fac-bcd0-d0cc89f801bb"), Type = TextBlockType.Text, Text = "The moving power of your songs can stir the spirits of the dead to rise once more and fight alongside you. You learn the (spell: song of the fallen) composition spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveFocusPool(Guid.Parse("aa68ab61-3399-4a5b-8d0f-d19669168e20"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1f35361d-4cc3-43b0-9925-75e28c62df02"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
