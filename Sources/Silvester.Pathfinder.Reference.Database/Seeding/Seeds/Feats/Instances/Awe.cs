using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Awe : Template
    {
        public static readonly Guid ID = Guid.Parse("9d2129de-2279-4fc0-8ca5-3ff8035cc869");

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
            yield return new TextBlock { Id = Guid.Parse("a3882e7a-7484-4e69-bb9b-86161451c26d"), Type = TextBlockType.Text, Text = "Your powerful sense of wonderment can be infectious and distracting." };
            yield return new TextBlock { Id = Guid.Parse("d3dfad3a-e73e-4aaf-8fac-fce590e72fa5"), Type = TextBlockType.Text, Text = "~ Catharsis Trigger: You or an ally within 30 feet critically succeeds on an attack roll against an enemy’s AC or a skill check against one of an enemy’s DCs." };
            yield return new TextBlock { Id = Guid.Parse("376e4788-038d-4288-a67a-e26cb64c11b2"), Type = TextBlockType.Text, Text = "~ Catharsis Activation: If you’re fascinated or stupefied, you can attempt an additional save to end the effect if it allowed a save." };
            yield return new TextBlock { Id = Guid.Parse("62c3daee-4548-4458-8425-a7c82f2859d8"), Type = TextBlockType.Text, Text = "~ Emotional Fervor: When you cast a spell, choose one creature that was hit by your spell attack roll or that failed its saving throw, if any. That creature becomes fascinated with you until the end of its next turn. It’s then temporarily immune to this fervor effect for 1 hour. Spell: (spell: glitterdust)" };
            yield return new TextBlock { Id = Guid.Parse("7de165b5-5e3d-4062-98ab-f38b708c86de"), Type = TextBlockType.Text, Text = "~ Emotional Fallout: You become flat-footed until you (feat: Settle your Emotions | Settle Emotions)." };
            yield return new TextBlock { Id = Guid.Parse("4aed299f-44de-44a4-8658-68e4a2c48664"), Type = TextBlockType.Text, Text = "~ Focus Spell: (spell: dazzling flash) (doesn’t require a religious symbol)" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2dbf3999-1d53-44cc-9ec6-207c5c93093e"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
