using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Awe : Template
    {
        public static readonly Guid ID = Guid.Parse("b12283df-a507-4d21-b981-6a282d360cac");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Awe",
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
            yield return new TextBlock { Id = Guid.Parse("4464752e-2629-46d2-9f2a-04cc8e66af16"), Type = TextBlockType.Text, Text = $"Your powerful sense of wonderment can be infectious and distracting." };
            yield return new TextBlock { Id = Guid.Parse("4ca52899-316a-47a8-a6bc-d78c28210488"), Type = TextBlockType.Text, Text = $"~ Catharsis Trigger: You or an ally within 30 feet critically succeeds on an attack roll against an enemy's AC or a skill check against one of an enemy's DCs." };
            yield return new TextBlock { Id = Guid.Parse("6b1e380b-6e4a-482b-895e-07bd9b5414fa"), Type = TextBlockType.Text, Text = $"~ Catharsis Activation: If you're fascinated or stupefied, you can attempt an additional save to end the effect if it allowed a save." };
            yield return new TextBlock { Id = Guid.Parse("88f5da14-cdda-4f93-a42c-c569f3d0bc91"), Type = TextBlockType.Text, Text = $"~ Emotional Fervor: When you cast a spell, choose one creature that was hit by your spell attack roll or that failed its saving throw, if any. That creature becomes fascinated with you until the end of its next turn. It's then temporarily immune to this fervor effect for 1 hour. Spell: {ToMarkdownLink<Models.Entities.Spell>("glitterdust", Spells.Instances.Glitterdust.ID)}" };
            yield return new TextBlock { Id = Guid.Parse("293c4cb8-e8d3-4247-b858-086da4bacdc6"), Type = TextBlockType.Text, Text = $"~ Emotional Fallout: You become flat-footed until you {ToMarkdownLink<Models.Entities.Feat>("Settle your Emotions", Feats.Instances.SettleEmotions.ID)}." };
            yield return new TextBlock { Id = Guid.Parse("27a991fa-f59f-43b3-b5a2-d8ffd65ec261"), Type = TextBlockType.Text, Text = $"~ Focus Spell: {ToMarkdownLink<Models.Entities.Spell>("dazzling flash", Spells.Instances.DazzlingFlash.ID)} (doesn't require a religious symbol)" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5433d5bb-203f-4309-a8df-9a10aa76ca3b"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
