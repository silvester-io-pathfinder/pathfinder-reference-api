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
    public class DragonDiscipleDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("7e37e5c7-e0bd-41c6-90d2-3644ca2986a0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dragon Disciple Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the dragon disciple archetype. If you later take the sorcerer archetype, you must choose the draconic bloodline.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("79700971-2d09-46c4-9c4d-014a6f873f99"), Type = TextBlockType.Text, Text = $"~ Access: You are a kobold with the dragonscaled or spellscaled heritage, a dragon instinct barbarian, or a draconic bloodline sorcerer." };
            yield return new TextBlock { Id = Guid.Parse("240d1c04-8374-4ab5-aaf8-6e4ffa33f6da"), Type = TextBlockType.Text, Text = $"You choose to study or worship one type of dragon, and your focus grants you a measure of its power. Choose one color of dragon when you select this feat; if you are a sorcerer with the draconic bloodline, this must be the same type as your bloodline. You gain resistance equal to half your level against one type of damage determined by the chosen dragon type. The GM may allow you to choose a dragon type not listed below, and will determine the damage type appropriate for that dragon." };
            yield return new TextBlock { Id = Guid.Parse("137fe05e-4ccd-43ff-815b-7b463b8b4ab9"), Type = TextBlockType.Text, Text = $"You also gain a +1 circumstance bonus to saving throws against {ToMarkdownLink<Models.Entities.Trait>("sleep", Traits.Instances.Sleep.ID)} effects and effects that would make you paralyzed." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("98d387d6-1428-432a-b54a-18454583885d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
