using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VirtuosicPerformer : Template
    {
        public static readonly Guid ID = Guid.Parse("53ac993b-b2db-4a5f-8ef4-a0d800e40940");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Virtuosic Performer",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("64e3e5c1-ba7d-45de-9182-f57c56dff030"), Type = TextBlockType.Text, Text = $"You have exceptional talent with one type of performance. You gain a +1 circumstance bonus when making a certain type of performance. If you are a master in Performance, this bonus increases to +2. Select one of the following specialties and apply the bonus when attempting Performance checks of that type. If it's unclear whether the specialty applies, the GM decides." };
            yield return new TextBlock { Id = Guid.Parse("f6961b41-bac5-45a5-bbf5-bf6c5c71af51"), Type = TextBlockType.Enumeration, Text = $"**Specialties***" };
            yield return new TextBlock { Id = Guid.Parse("41cb2cb7-70c2-49d5-9dbb-639c4165060f"), Type = TextBlockType.Enumeration, Text = $" Acting: Drama, pantomime, puppetry" };
            yield return new TextBlock { Id = Guid.Parse("d665262b-d402-42de-bf53-0de0ecd8d3a0"), Type = TextBlockType.Enumeration, Text = $" Comedy: Buffoonery, joke telling, limericks" };
            yield return new TextBlock { Id = Guid.Parse("448e72e0-87d2-4843-bc76-57e1bdb50d3e"), Type = TextBlockType.Enumeration, Text = $" Dance: Ballet, huara, jig, macru" };
            yield return new TextBlock { Id = Guid.Parse("cf872cd8-c5c7-473e-a34e-272829661883"), Type = TextBlockType.Enumeration, Text = $" Keyboards: Harpsichord, organ, piano" };
            yield return new TextBlock { Id = Guid.Parse("e0636a9c-2f35-4704-8326-9447d42494b5"), Type = TextBlockType.Enumeration, Text = $" Oratory: Epic, ode, poetry, storytelling" };
            yield return new TextBlock { Id = Guid.Parse("b53f60e8-bcc9-4a1c-b4f1-974e6bd9726d"), Type = TextBlockType.Enumeration, Text = $" Percussion: Chimes, drum, gong, xylophone" };
            yield return new TextBlock { Id = Guid.Parse("9027a8cf-de2e-4ad1-9fe6-63e0f683e8ee"), Type = TextBlockType.Enumeration, Text = $" Singing: Ballad, chant, melody, rhyming" };
            yield return new TextBlock { Id = Guid.Parse("31a3b9e4-ca4c-4c6d-a9eb-a933b22104f7"), Type = TextBlockType.Enumeration, Text = $" Strings: Fiddle, harp, lute, viol" };
            yield return new TextBlock { Id = Guid.Parse("2704f97c-a97f-4835-be44-0443276aada2"), Type = TextBlockType.Enumeration, Text = $" Winds: Bagpipe, flute, recorder, trumpet" };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("07a5e05c-dc71-4333-a9e8-71f24131a9e5"), Proficiencies.Instances.Trained.ID, Skills.Instances.Performance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f0f050b2-002d-4198-8104-b62660299024"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
