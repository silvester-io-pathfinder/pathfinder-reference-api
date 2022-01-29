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
    public class EsotericAntithesis : Template
    {
        public static readonly Guid ID = Guid.Parse("3a92faea-48e3-4c72-9b63-0e6e8f121d77");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Esoteric Antithesis",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("96658fa1-c3ae-431b-8062-133e530410bb"), Type = TextBlockType.Text, Text = $"You search through your esoterica to find the right trinket that will apply a weakness to your attacks against the creature you {ToMarkdownLink<Models.Entities.Feat>("Found Flaws", Feats.Instances.FindFlaws.ID)} in. You Interact to apply specific esoterica to yourself and your weapons; you can perform this {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} action with the hand holding your implement. Your unarmed and weapon {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} against the creature become magical if they weren't already, and you cause them to apply one of the creature's weaknesses even if they don't deal the correct type of damage. If the creature has a weakness with a value of 2 + half your level or higher, set the type of weakness to the creature's highest weakness. Otherwise, you create a custom weakness with a value equal to 2 + half your level; this weakness applies only to your {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)}. For example, against a tyrant, you might attach a chain broken to free a captive. This effect lasts until you use {ToMarkdownLink<Models.Entities.Feat>("Find Flaws", Feats.Instances.FindFlaws.ID)} again." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f2313aef-85c9-4645-98d0-5b9deab634ce"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
