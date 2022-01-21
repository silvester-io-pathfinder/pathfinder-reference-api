using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CobraStance : Template
    {
        public static readonly Guid ID = Guid.Parse("e3c9bf34-d74e-422f-af2f-138e14dbeb96");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cobra Stance",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f9d3bc9e-d94c-4206-ade9-c1902124264c"), Type = TextBlockType.Text, Text = $"You enter a tight stance, coiled up like a lashing cobra with your hands poised as venomous fangs. While in this stance, the only {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} you can make are cobra fang unarmed attacks. These deal 1d4 poison damage; are in the brawling group; and have the {ToMarkdownLink<Models.Entities.Trait>("agile", Traits.Instances.Agile.ID)}, {ToMarkdownLink<Models.Entities.Trait>("deadly", Traits.Instances.Deadly.ID)}, {ToMarkdownLink<Models.Entities.Trait>("finesse", Traits.Instances.Finesse.ID)}, {ToMarkdownLink<Models.Entities.Trait>("nonlethal", Traits.Instances.Nonlethal.ID)}, {ToMarkdownLink<Models.Entities.Trait>("poison", Traits.Instances.Poison.ID)}, and {ToMarkdownLink<Models.Entities.Trait>("unarmed", Traits.Instances.Unarmed.ID)} traits." };
            yield return new TextBlock { Id = Guid.Parse("02d3858b-56ef-48a9-89c4-c95bc6fd20bf"), Type = TextBlockType.Text, Text = $"While in Cobra Stance, you gain a +1 circumstance bonus to Fortitude saves and your Fortitude DC, and you gain poison resistance equal to half your level." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("af739663-209d-4be1-8daa-33f32f10332e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
