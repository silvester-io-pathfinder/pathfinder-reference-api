using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DousingSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("14111af2-5f9a-47df-8ab6-1574b3531101");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dousing Spell",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b41bf111-a7d1-4005-ac3e-85322b3c2f45"), Type = TextBlockType.Text, Text = $"You enhance your spell with elemental water, soaking the target. If the next action you use is to Cast a Spell targeting a single creature, you soak the target of the spell with water. If the target has persistent acid or fire damage, the DC to end those conditions is reduced to 10, and the creature can attempt a flat check to end those types of persistent damage immediately. The spell gains the {ToMarkdownLink<Models.Entities.Trait>("water", Traits.Instances.Water.ID)} trait (causing it to deal extra damage to creatures with weakness to water)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("62b0b838-0015-4e7b-9114-4907cdb6d58e"), Feats.Instances.ElementalistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e1bb974a-1b95-4af3-9cbf-14069be5d17e"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
