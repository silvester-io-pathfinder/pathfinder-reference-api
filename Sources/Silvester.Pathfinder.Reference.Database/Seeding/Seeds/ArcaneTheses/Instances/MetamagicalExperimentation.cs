using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ArcaneTheses.Instances
{
    public class MetamagicalExperimentation : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ArcaneThesis GetArcaneThesis()
        {
            return new ArcaneThesis
            {
                Id = ID, 
                Name = "Metamagical Experimentation", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You've realized that the practice known as metamagic is a holdover from a time long ago, when wizards had to work out their own spells and variations rather than rely on spells recorded by others and passed down over the years. This allows you efficient access to various metamagic effects." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You gain one 1st-level metamagic wizard feat of your choice. Starting at 4th level, during your daily preparations, you can gain a metamagic wizard feat of your choice that has a level requirement of no more than half your level, which you can use until your next daily preparations." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificTraitSpellEffect { Id = Guid.Parse(""), TraitId = Traits.Instances.Metamagic.ID };
            //TODO: Temporary metamagic wizard feat effect.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 205
            };
        }
    }
}
