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
    public class DevastatingSpellstrike : Template
    {
        public static readonly Guid ID = Guid.Parse("2e51f0d8-5a7f-43a5-a2a6-90b3dc9c20b2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Devastating Spellstrike",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("618dfe5f-0ed0-41ff-8180-8d5a6d7af65b"), Type = TextBlockType.Text, Text = $"Your {ToMarkdownLink<Models.Entities.Feat>("Spellstrike", Feats.Instances.Spellstrike.ID)} sweeps are so wide and devastating, they splash onto nearby foes. Make a {ToMarkdownLink<Models.Entities.Feat>("Spellstrike", Feats.Instances.Spellstrike.ID)}. Foes adjacent to the target take splash damage equal to 2 + the extra damage from {ToMarkdownLink<Models.Entities.Feat>("Arcane Cascade", Feats.Instances.ArcaneCascade.ID)}. The damage type is the same as {ToMarkdownLink<Models.Entities.Feat>("Arcane Cascade", Feats.Instances.ArcaneCascade.ID)}; if the spell already deals splash damage of the same type, combine the damage together before applying weaknesses or resistances." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0cd75fc1-f3ad-441a-9ee7-805234d59527"), Feats.Instances.ArcaneCascade.ID);
            builder.HaveSpecificHybridStudy(Guid.Parse("5b8b1690-0edf-454f-a56a-fc8075b163dd"), HybridStudies.Instances.InexorableIron.ID);
            builder.HaveSpecificFeat(Guid.Parse("681fcba4-e98e-47a5-b6db-fd272cb3efdd"), Feats.Instances.Spellstrike.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("d307e775-e38c-4b7f-88e2-5d0949fff10d"), Traits.Instances.Magus.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("863c2fe5-a212-4ee1-8822-178c43b7db30"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
