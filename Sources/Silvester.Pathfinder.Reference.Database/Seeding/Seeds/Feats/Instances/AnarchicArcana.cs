using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AnarchicArcana : Template
    {
        public static readonly Guid ID = Guid.Parse("4732c6d8-85ca-48ea-90ed-61dc2e3f1e94");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Anarchic Arcana",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6d44083c-bd64-4bc9-a0c1-d6b27b7ff07f"), Type = TextBlockType.Text, Text = "The magic in your blood is unpredictable. When you make your daily preparations, roll 1d12 twice and consult the following list." };
            yield return new TextBlock { Id = Guid.Parse("a876a18b-2eb2-4a09-9bb9-5277bcb4e4ef"), Type = TextBlockType.Enumeration, Text = " 1: (spell: acid arrow)" };
            yield return new TextBlock { Id = Guid.Parse("e13da87d-0f88-41c6-a738-c4b02052cec6"), Type = TextBlockType.Enumeration, Text = " 2: (spell: blur)" };
            yield return new TextBlock { Id = Guid.Parse("d12a1ef4-37a0-4e54-85a3-37dc3426b12c"), Type = TextBlockType.Enumeration, Text = " 3: (spell: hideous laughter)" };
            yield return new TextBlock { Id = Guid.Parse("cbf4cef4-78dc-47ed-aeb3-cf1823a8ad7c"), Type = TextBlockType.Enumeration, Text = " 4: (spell: humanoid form)" };
            yield return new TextBlock { Id = Guid.Parse("239c8175-9d53-4c77-b57f-d5963a83e8a5"), Type = TextBlockType.Enumeration, Text = " 5: (spell: illusory object)" };
            yield return new TextBlock { Id = Guid.Parse("4b4b1585-7574-44da-8a8d-d20bf01d98f4"), Type = TextBlockType.Enumeration, Text = " 6: (spell: mirror image)" };
            yield return new TextBlock { Id = Guid.Parse("deea390c-6f95-41f5-a971-a527438bf600"), Type = TextBlockType.Enumeration, Text = " 7: (spell: resist energy)" };
            yield return new TextBlock { Id = Guid.Parse("d5f31bc1-79cd-4f12-a61a-fb610deef872"), Type = TextBlockType.Enumeration, Text = " 8: (spell: see invisibility)" };
            yield return new TextBlock { Id = Guid.Parse("b607a93b-f8c0-4f93-8067-24420d315f91"), Type = TextBlockType.Enumeration, Text = " 9: (spell: shatter)" };
            yield return new TextBlock { Id = Guid.Parse("dfde6bd6-f028-499a-9fbf-2fc96098a82e"), Type = TextBlockType.Enumeration, Text = " 10: (spell: sound burst)" };
            yield return new TextBlock { Id = Guid.Parse("907412e0-e247-43bf-9c91-46d40ffd8c5b"), Type = TextBlockType.Enumeration, Text = " 11: (spell: spider climb)" };
            yield return new TextBlock { Id = Guid.Parse("aaef4c9b-1b33-4a86-86ef-b0c754487657"), Type = TextBlockType.Enumeration, Text = " 12: (spell: telekinetic maneuver)" };
            yield return new TextBlock { Id = Guid.Parse("dda04676-0481-434b-a986-39baf06965b1"), Type = TextBlockType.Text, Text = "You can cast each of those two spells once during the following day (or one spell twice if you rolled doubles) as 2nd-level divine innate spells." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dc0658c5-c6f2-4442-9900-0c90a5c3b423"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
