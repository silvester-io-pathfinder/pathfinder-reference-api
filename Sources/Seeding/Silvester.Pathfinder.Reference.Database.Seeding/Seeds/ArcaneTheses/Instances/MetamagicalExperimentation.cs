using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ArcaneTheses.Instances
{
    public class MetamagicalExperimentation : Template
    {
        public static readonly Guid ID = Guid.Parse("da708c67-092d-4b15-b90e-93108e0386ad");

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
            yield return new TextBlock { Id = Guid.Parse("a301f11b-fbbf-4e31-bbbb-d0631541c316"), Type = TextBlockType.Text, Text = "You've realized that the practice known as metamagic is a holdover from a time long ago, when wizards had to work out their own spells and variations rather than rely on spells recorded by others and passed down over the years. This allows you efficient access to various metamagic effects." };
            yield return new TextBlock { Id = Guid.Parse("24e18620-0349-4b53-ad62-61aadc07ce65"), Type = TextBlockType.Text, Text = "You gain one 1st-level metamagic wizard feat of your choice. Starting at 4th level, during your daily preparations, you can gain a metamagic wizard feat of your choice that has a level requirement of no more than half your level, which you can use until your next daily preparations." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("737fa723-99e2-4c03-b552-bb80df38f1fc"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 205
            };
        }
    }
}
