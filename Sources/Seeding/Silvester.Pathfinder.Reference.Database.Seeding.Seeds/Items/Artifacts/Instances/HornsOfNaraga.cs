using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Artifacts.Instances
{
    public class HornsOfNaraga : Template
    {
        public static readonly Guid ID = Guid.Parse("c718686d-6681-474a-8bfa-3d89c5040e11");

        protected override Artifact GetArtifact()
        {
            return new Artifact
            {
                Id = ID,
                Name = "Horns of Naraga",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("3c772c10-e144-498e-b4e9-c8cd7c03eabd"), "This imposing helm bears the horns of a powerful black dragon. While wearing the Horns of Naraga, you gain greater darkvision and immunity to acid. If you are undead, you gain resistance 40 to positive damage. If you are not undead, the helm quickly saps the life from you, dealing 10d6 negative damage to you every round. If you die from this damage, you rise as an undead of an equal level in 1d4 rounds.");;
        }

        protected override IEnumerable<ArtifactVariant> GetArtifactVariants()
        {
            yield return new ArtifactVariant
            {
                Id = Guid.Parse("0fa778cd-0f1f-4c6e-a2b4-cb0a71eb9674"),
                Name = "",
                Usage = "Worn headwear.",
                Destruction = "The helm is utterly obliterated if crushed between the jaws of an ancient black dragon's skull located in a desert while the sun is at its zenith.",
                Level = 26,
                RarityId = Rarities.Instances.Unique.ID,
                BulkId = Bulks.Instances.TwoBulk.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("c65e81aa-a1fd-43f3-a97f-e3fa36fc61dd"), ActionTypes.Instances.FreeAction.ID, "Activate", action =>
                    {
                        action
                           .Kind("Envision")
                           .Trigger("You touch a creature as part of an unarmed attack or melee spell attack roll.")
                           .Details(effect =>
                           {
                               effect.Text(Guid.Parse("03356da7-c9d9-4627-b3e7-dd72da589b9e"), "The creature takes 5d6 negative damage. If you are an undead, you regain Hit Points equal to the negative damage the creature took.");
                           });
                    })
                    .Add(Guid.Parse("b25e7a3f-5ab4-425c-8da2-4ada7094cd82"), ActionTypes.Instances.ThreeActions.ID, "Activate", action =>
                    {
                        action
                           .Kind("Command")
                           .Frequency("Once per day.")
                           .Details(effect =>
                           {
                               effect.Text(Guid.Parse("97a22ccf-affe-470e-ab0b-2c373d3dff8e"), "The Horns of Naraga transform into Naraga, an ancient black dragon. Naraga appears in an adjacent appropriate space, and if no such space is available, she does not appear. Naraga follows your commands without question. She remains for up to 1 hour or until you use an Interact action to dismiss her, after which she reverts back to the helm. If Naraga is slain, she immediately reverts back to the helm and can't be summoned for 1 week. You don't receive any of the helm's other benefits while it is transformed.");
                           });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("c9752b39-43fa-4469-894c-c54009fd8cf2"), Traits.Instances.Unique.ID);
            builder.Add(Guid.Parse("900074cb-785b-428b-9a50-4ce514e66753"), Traits.Instances.Artifact.ID);
            builder.Add(Guid.Parse("9bc00235-ca3f-4df9-9c00-782ae0152e61"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("572a1a3d-f214-4785-af27-06510feba605"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("61102567-02ad-4b02-9dd8-6ec15c239901"), Traits.Instances.Necromancy.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fb13a8a5-632e-495e-8949-d4efabd73b2e"),
                SourceId = Sources.Instances.GamemasteryGuide.ID,
                Page = 109
            };
        }
    }
}
