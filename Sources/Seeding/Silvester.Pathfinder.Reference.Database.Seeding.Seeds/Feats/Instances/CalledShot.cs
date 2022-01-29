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
    public class CalledShot : Template
    {
        public static readonly Guid ID = Guid.Parse("b2a71673-70e8-4def-937c-fcc1cd711ca2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Called Shot",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cb2d4988-e85e-453f-911b-1d9f6bf467c5"), Type = TextBlockType.Text, Text = $"You target a specific area of your foe's anatomy to debilitating effect. Declare a part of your foe's anatomy to target and make a ranged weapon {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}. If you hit and deal damage, the target takes one of the following effects, based on the body part you targeted. The GM should use the stated effects as a guideline when attacking creatures with stranger anatomy—for instance, applying the “arms” effect to a creature's tentacles if those are what the creature uses to attack." };
            yield return new TextBlock { Id = Guid.Parse("2b9a5e78-1506-4f4e-b707-9ce31d638aa1"), Type = TextBlockType.Enumeration, Text = $" Arms: The target is enfeebled 2 until the end of your next turn. On a critical hit, it's also enfeebled 1 for 1 minute." };
            yield return new TextBlock { Id = Guid.Parse("85fd09ad-7605-4c56-aab9-dd464c87e8d3"), Type = TextBlockType.Enumeration, Text = $" Head: The target is stupefied 2 until the end of your next turn. On a critical hit, it's also stupefied 1 for 1 minute." };
            yield return new TextBlock { Id = Guid.Parse("79e8974f-197a-41d8-9256-1976de5ae428"), Type = TextBlockType.Enumeration, Text = $" Legs: The target takes a –10-foot status penalty to its Speeds until the end of your next turn. On a critical hit, it also takes a –5-foot penalty to its Speeds for 1 minute." };
            yield return new TextBlock { Id = Guid.Parse("adf344e6-77ee-42d3-8e16-b946a772e233"), Type = TextBlockType.Enumeration, Text = $" Wings: If the target is flying using its wings, it immediately falls 20 feet, or 40 feet on a critical hit. The fall is gradual enough that if the target hits the ground, it takes no damage from the fall." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bbc10a2c-828f-45cb-a8b7-3d5f297ab386"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
