using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SnareGenius : Template
    {
        public static readonly Guid ID = Guid.Parse("00c9a611-fe3a-424e-91fb-f6ecc5eb42e6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Snare Genius",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fc89f0ba-add7-449e-a9a4-38445bf1537d"), Type = TextBlockType.Text, Text = $"Your expertise makes your snares more powerful, and you can place them quickly and efficiently. Each day during your daily preparations, you can prepare three snares from your formula book for quick deployment; if the snare normally takes 1 minute to {ToMarkdownLink<Models.Entities.SkillAction>("Craft", SkillActions.Instances.Craft.ID)}, you can {ToMarkdownLink<Models.Entities.SkillAction>("Craft", SkillActions.Instances.Craft.ID)} it with 3 {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} actions. Snares prepared in this way don't cost you any resources to {ToMarkdownLink<Models.Entities.SkillAction>("Craft", SkillActions.Instances.Craft.ID)}. The number of snares you can prepare this way increases to four if you are a master in Crafting, and to five if you are legendary." };
            yield return new TextBlock { Id = Guid.Parse("fc4a9194-b7d9-4fbe-b9b3-066665d5c86b"), Type = TextBlockType.Text, Text = $"When you {ToMarkdownLink<Models.Entities.SkillAction>("Craft", SkillActions.Instances.Craft.ID)} and deploy a snare that deals damage, any creature that critically fails its saving throw against the snare's initial effect and takes damage becomes flat-footed until the end of its next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("c1b5d1a8-d91a-4dbf-b0b9-2245ba770e3d"), Proficiencies.Instances.Expert.ID, Skills.Instances.Crafting.ID);
            builder.HaveSpecificFeat(Guid.Parse("5db21cbf-9c43-49c4-800a-3d6926a7641b"), Feats.Instances.SnareCrafting.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Kobold.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a6685bee-957a-42b2-99d0-2574493633a5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
