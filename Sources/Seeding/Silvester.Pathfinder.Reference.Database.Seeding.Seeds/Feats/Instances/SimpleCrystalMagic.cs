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
    public class SimpleCrystalMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("8fca1e9c-db0a-4283-96f1-02174af6a52e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Simple Crystal Magic",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5da3c14f-8f2f-4164-88a5-c853f3e6430b"), Type = TextBlockType.Text, Text = $"As long as you meditate before a gemstone worth at least 10 gp as part of your daily preparations, you are capable of seeing magic as flowing runes that reveal information about magic objects, and you can scribe a personal rune that represents you. You gain the {ToMarkdownLink<Models.Entities.Spell>("read aura", Spells.Instances.ReadAura.ID)} and {ToMarkdownLink<Models.Entities.Spell>("sigil", Spells.Instances.Sigil.ID)} cantrips. You cast these cantrips as arcane innate spells at will. A cantrip is heightened to a spell level equal to half your level rounded up." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("86fbcd45-2ac1-434f-bd8b-152d107cee0e"), Feats.Instances.CrystalKeeperDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fe856e09-a02a-4791-9564-e666b8e0339b"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
