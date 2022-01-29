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
    public class DualThrower : Template
    {
        public static readonly Guid ID = Guid.Parse("2f006225-a0c9-4833-8d44-70850a755106");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dual Thrower",
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
            yield return new TextBlock { Id = Guid.Parse("1948065e-833e-4be6-80ce-7b441615394e"), Type = TextBlockType.Text, Text = $"You know how to throw two weapons as easily as strike with them. Whenever a dual-weapon warrior feat allows you to make a melee {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}, you can instead make a ranged {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with a {ToMarkdownLink<Models.Entities.Trait>("thrown", Traits.Instances.Thrown.ID)} weapon or a one-handed ranged weapon you are wielding. Any effects from these feats that apply to one-handed melee weapons or melee {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} also apply to one-handed ranged weapons and ranged {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("feb5c036-2c1a-42f6-80ca-d6df7cc18fc7"), Feats.Instances.DualWeaponWarriorDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("914edafc-4533-408b-90f6-d30048d803e2"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
