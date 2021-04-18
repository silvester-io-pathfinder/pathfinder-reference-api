using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class AugurySpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "No Action";
        public override string MagicSchool => "Divination";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("cfb3f479-70d2-4275-890f-27920ec70d3d"),
                Name = "Augury",
                Level = 2,
                CastTime = TimeSpan.FromMinutes(10)
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("252c9500-8bda-4a59-ab54-fec870f557e9"), Type = Utilities.Text.TextBlockType.Text, Text = "You gain a vague glimpse of the future. During the casting of this spell, ask about the results of a particular course of action." };
            yield return new TextBlock { Id = Guid.Parse("7f34d0c1-10ae-4937-a9fb-aae94c21ff6e"), Type = Utilities.Text.TextBlockType.Text, Text = "The spell can predict results up to 30 minutes into the future and reveals the GM’s best guess among the following outcomes:" };
            yield return new TextBlock { Id = Guid.Parse("62aac3fd-dc88-4275-b479-964d0e390ef0"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "Weal: The results will be good." };
            yield return new TextBlock { Id = Guid.Parse("a360bbe1-1f56-4bac-b1b5-a8dab82d5659"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "Woe: The results will be bad." };
            yield return new TextBlock { Id = Guid.Parse("ef5d40a9-0203-48f4-9744-f411c7a97342"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "Weal and Woe: The results will be a mix of good and bad." };
            yield return new TextBlock { Id = Guid.Parse("ba4c847a-4c45-4d7b-adb4-41a03b562606"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "Nothing: There won’t be particularly good or bad results." };
            yield return new TextBlock { Id = Guid.Parse("702a5b5e-0fad-48db-b126-02b58069b5f7"), Type = Utilities.Text.TextBlockType.Text, Text = "The GM rolls a secret DC 6 flat check. On a failure, the result is always “nothing.” This makes it impossible to tell whether a “nothing” result is accurate. If anyone asks about the same topic as the first casting of augury during an additional casting, the GM uses the secret roll result from the first casting. If circumstances change, though, it’s possible to get a different result." };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Material";
            yield return "Somatic";
            yield return "Verbal";
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Divine";
            yield return "Occult";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Divination";
            yield return "Prediction";
        }
    }
}
