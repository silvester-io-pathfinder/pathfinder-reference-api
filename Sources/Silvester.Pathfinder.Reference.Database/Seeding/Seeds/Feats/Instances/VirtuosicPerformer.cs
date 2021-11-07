using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VirtuosicPerformer : Template
    {
        public static readonly Guid ID = Guid.Parse("46e29893-86a8-4678-adf1-275affa14630");

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
            yield return new TextBlock { Id = Guid.Parse("c2c4d79f-3de0-40d3-804b-37c221a29334"), Type = TextBlockType.Text, Text = "You have exceptional talent with one type of performance. You gain a +1 circumstance bonus when making a certain type of performance. If you are a master in Performance, this bonus increases to +2. Select one of the following specialties and apply the bonus when attempting Performance checks of that type. If it’s unclear whether the specialty applies, the GM decides." };
            yield return new TextBlock { Id = Guid.Parse("4d5a6ed5-ba1b-426f-9e23-4e5f01cd8624"), Type = TextBlockType.Enumeration, Text = "**Specialties***" };
            yield return new TextBlock { Id = Guid.Parse("74319b0e-9e15-4319-a8da-4fc40f0ad401"), Type = TextBlockType.Enumeration, Text = " Acting: Drama, pantomime, puppetry" };
            yield return new TextBlock { Id = Guid.Parse("31751aa8-dc17-4a9b-ba92-707f2c7856f5"), Type = TextBlockType.Enumeration, Text = " Comedy: Buffoonery, joke telling, limericks" };
            yield return new TextBlock { Id = Guid.Parse("e3467db8-1c4d-4e4b-a1f5-c59fec175a83"), Type = TextBlockType.Enumeration, Text = " Dance: Ballet, huara, jig, macru" };
            yield return new TextBlock { Id = Guid.Parse("0c343841-fb01-44c3-92a2-fe5a70b99f4c"), Type = TextBlockType.Enumeration, Text = " Keyboards: Harpsichord, organ, piano" };
            yield return new TextBlock { Id = Guid.Parse("6d923c64-1207-457d-86e9-c426bb96f2c9"), Type = TextBlockType.Enumeration, Text = " Oratory: Epic, ode, poetry, storytelling" };
            yield return new TextBlock { Id = Guid.Parse("868efdb8-693e-49bb-9e2c-9642e260f995"), Type = TextBlockType.Enumeration, Text = " Percussion: Chimes, drum, gong, xylophone" };
            yield return new TextBlock { Id = Guid.Parse("75fd3d52-c136-4679-8482-b6f4d60b742a"), Type = TextBlockType.Enumeration, Text = " Singing: Ballad, chant, melody, rhyming" };
            yield return new TextBlock { Id = Guid.Parse("04effdec-4b32-424c-ab3f-d93b3046a921"), Type = TextBlockType.Enumeration, Text = " Strings: Fiddle, harp, lute, viol" };
            yield return new TextBlock { Id = Guid.Parse("632a134c-676f-40e9-86c3-66a29983c4cd"), Type = TextBlockType.Enumeration, Text = " Winds: Bagpipe, flute, recorder, trumpet" };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("563fbc54-3280-4357-a955-aaa83e9f9cfa"), Proficiencies.Instances.Trained.ID, Skills.Instances.Performance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9c2eb5b3-82e1-464a-8723-35d1ed3dc626"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
