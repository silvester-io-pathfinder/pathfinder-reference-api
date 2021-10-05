using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Artifacts.Instances
{
    public class AxeOfTheDwarvenLords : Template
    {
        public static readonly Guid ID = Guid.Parse("698dcef9-9c91-435c-9fc1-e81f0ec05113");

        protected override Artifact GetArtifact()
        {
            return new Artifact
            {
                Id = ID,
                Name = "Axe of the Dwarven Lords",
                Destruction = "If an orc beheads a dwarven king with the Axe of the Dwarven Lords, the axe rusts away to nothing.",
                Usage = "Held in 2 hands.",
                ItemLevel = 26,
                BulkId = Bulks.Instances.ThreeBulk.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("740c73e9-7624-4402-89be-75b7f1b0c358"), Type = TextBlockType.Text, Text = "The blade of this +4 major striking keen returning speed dwarven waraxe is carved with an intricate design depicting countless generations of great dwarven warriors and leaders. The axe has the thrown 30 feet weapon trait, in addition to the normal weapon traits for a dwarven waraxe. Strikes with the axe deal an additional 1d6 damage to orcs. While the axe is in your possession, you gain a +4 item bonus when Crafting armor, jewelry, metalworking, stonemasonry, snares, traps, and weapons. If you are a dwarf, you gain greater darkvision while holding the axe. If you are not a dwarf, you are stupefied 4 while holding the axe, and if you are an orc, you are also drained 4 and enfeebled 4 while holding it." };
        }

        protected override IEnumerable<ArtifactAction> GetActions()
        {
            yield return new ArtifactAction
            {
                Id = Guid.Parse("21e49cbb-ab50-4035-a15e-fde6a0832c4a"),
                Name = "Envision, Interact",
                Frequency = "Once per week.",
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                Effects = new[] 
                {
                    new TextBlock { Id = Guid.Parse("0820e64c-31ca-4c14-b80b-99724bf66342"), Type = TextBlockType.Text, Text = "The axe casts a 10th-level summon elemental spell to conjure an elite elemental avalanche. The spell is automatically sustained, requiring no action on your part but still allowing you to command the elemental on each of your turns. You can Dismiss the Spell." }
                }
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Unique.ID;
            yield return Traits.Instances.Artifact.ID;
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a5e7030d-d535-463a-a69b-7e2e7fd31e0c"),
                SourceId = Sources.Instances.GamemasteryGuide.ID,
                Page = 106
            };
        }
    }
}
