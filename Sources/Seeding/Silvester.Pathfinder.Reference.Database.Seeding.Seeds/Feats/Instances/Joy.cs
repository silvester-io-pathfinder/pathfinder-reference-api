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
    public class Joy : Template
    {
        public static readonly Guid ID = Guid.Parse("4ac004fc-47ce-40dd-9526-de15e75ade0d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Joy",
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
            yield return new TextBlock { Id = Guid.Parse("fcc62edd-f35f-4a08-8e3a-3d8b71c1fc63"), Type = TextBlockType.Text, Text = $"Your unbridled enthusiasm and positive attitude can lead you to success, but you might expend more energy than you planned." };
            yield return new TextBlock { Id = Guid.Parse("020d2521-48ae-45dc-9d52-a56aa1aa2ac7"), Type = TextBlockType.Text, Text = $"~ Catharsis Trigger: You critically succeed on an attack roll or save, or an enemy critically fails on a save against you." };
            yield return new TextBlock { Id = Guid.Parse("9e4a77c7-380a-45f5-ba62-788e87ab404a"), Type = TextBlockType.Text, Text = $"~ Catharsis Activation: Reduce the value of any frightened or stupefied condition you have by 1 and end any persistent mental damage you have." };
            yield return new TextBlock { Id = Guid.Parse("e92b535d-1dc0-4a69-9dde-026c555ccda3"), Type = TextBlockType.Text, Text = $"~ Emotional Fervor: You gain a +1 status bonus to Performance checks and to the spell attack rolls of emotion spells, and enemies take a –1 status penalty to saves against your emotion spells. Spell: {ToMarkdownLink<Models.Entities.Spell>("hideous laughter", Spells.Instances.HideousLaughter.ID)}" };
            yield return new TextBlock { Id = Guid.Parse("88e7985d-724a-4bab-9f12-b516e4d1692a"), Type = TextBlockType.Text, Text = $"~ Emotional Fallout: You become fatigued until you {ToMarkdownLink<Models.Entities.Feat>("Settle your Emotions", Feats.Instances.SettleEmotions.ID)}." };
            yield return new TextBlock { Id = Guid.Parse("e94263cd-7718-41e7-9521-f6f3a26634b8"), Type = TextBlockType.Text, Text = $"~ Focus Spell: {ToMarkdownLink<Models.Entities.Spell>("unimpeded stride", Spells.Instances.UnimpededStride.ID)}" };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0cb4ddfa-5966-421b-812b-4559c597154c"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
