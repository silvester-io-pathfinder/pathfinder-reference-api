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
    public class ElementalFamiliar : Template
    {
        public static readonly Guid ID = Guid.Parse("a8f13417-bd1c-43f5-96c2-82e7984088ee");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Elemental Familiar",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9ac27cf5-c2b6-432a-a113-8b8bd0d45cc4"), Type = TextBlockType.Text, Text = $"Your familiar becomes an elemental spirit capable of taking on aspects of the four elements: air, earth, fire, or water. Other than taking the form of an elemental instead of an animal, this familiar continues to use all the same rules as other familiars. Your familiar gains one additional familiar ability each day, which must be one of the following elemental familiar abilities. While your familiar has an elemental familiar ability, your familiar is composed of the associated elemental matter and gains the matching elemental trait. You can't select more than one elemental familiar ability at a time." };
            yield return new TextBlock { Id = Guid.Parse("4724cb19-a456-413c-8cac-0a2adf17fd7c"), Type = TextBlockType.Enumeration, Text = $" Air: If your familiar stays completely still for 1 round, it becomes invisible until it next takes an action. Any motion, even being moved or carried by another creature, ends this effect." };
            yield return new TextBlock { Id = Guid.Parse("53cfd8be-c708-47d0-b173-54ff2f9d444c"), Type = TextBlockType.Enumeration, Text = $" Earth: Your familiar gains resistance to physical damage (except adamantine) equal to half your level." };
            yield return new TextBlock { Id = Guid.Parse("bb2a4a79-c1c7-4f7b-8c14-c452dcde1482"), Type = TextBlockType.Enumeration, Text = $" Fire: Your familiar sheds bright light in a 20-foot radius (and dim light for the next 20 feet) and emits warmth. Creatures that remain within a 15-foot emanation don't take damage from severe environmental cold." };
            yield return new TextBlock { Id = Guid.Parse("d64daef1-4ce1-46a2-afc0-dd0aa7553568"), Type = TextBlockType.Enumeration, Text = $" Water: Your familiar can move through a gap at least 2 inches wide without Squeezing and can Squeeze through a gap at least 1 inch wide." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("731723e3-d9a9-4e2b-a0f3-8cd3967517d6"), Feats.Instances.ElementalistDedication.ID);
            builder.HaveSpecificFeat(Guid.Parse("7cf3b645-8764-4c54-8572-fb9ef0ae488d"), Feats.Instances.Familiar.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("c837cc69-ce34-401d-9564-9b27aba0aa3e"), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("31f5a5fa-3996-46ea-a29c-13884ba47072"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
