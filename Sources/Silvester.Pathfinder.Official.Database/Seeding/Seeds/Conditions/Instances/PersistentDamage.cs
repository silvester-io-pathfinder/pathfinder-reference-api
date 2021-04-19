using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class PersistentDamage : AbstractConditionTemplate
    {
        public static readonly Guid ID = Guid.Parse("e224b6c0-c7aa-4a58-b00f-7c422a7c6250");

        public override Condition GetCondition(ConditionSeeder seeder)
        {
            return new Condition
            {
                Id = ID,
                Name = "Persistent Damage",
            };
        }

        public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("61aba62f-6e0b-47e6-87dc-cf5d1f2958f3"), Type = Utilities.Text.TextBlockType.Text, Text = "Persistent damage comes from effects like acid, being on fire, or many other situations. It appears as “X persistent [type] damage,” where “X” is the amount of damage dealt and “[type]” is the damage type. Instead of taking persistent damage immediately, you take it at the end of each of your turns as long as you have the condition, rolling any damage dice anew each time. After you take persistent damage, roll a DC 15 flat check to see if you recover from the persistent damage. If you succeed, the condition ends." };
        }

        public override SourcePage? GetSourcePage(ConditionSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("504d4f87-0814-47b5-9377-ad05b72cd72a"),
                SourceId = CoreRulebook.ID,
                Page = 621
            };
        }

        /*public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d079a8d0-b445-4132-acb8-e9b73c5646d8"), Type = TextBlockType.Title, Text = "Persistent Damage Rules" };
            yield return new TextBlock { Id = Guid.Parse("9be7ab5f-d8ec-4502-a9db-63cabc34043b"), Type = TextBlockType.Text, Text = "The additional rules presented below apply to persistent damage in certain cases." };
            yield return new TextBlock { Id = Guid.Parse("7a6f2181-416a-491a-9d86-cce240b39331"), Type = TextBlockType.Text, Text = "Persistent damage runs its course and automatically ends after a certain amount of time as fire burns out, blood clots, and the like. The GM determines when this occurs, but it usually takes 1 minute." };
            yield return new TextBlock { Id = Guid.Parse("ab2056b6-550f-41a8-a96d-869cc17e3576"), Type = TextBlockType.Title, Text = "Assisted Recovery" };
            yield return new TextBlock { Id = Guid.Parse("1dd5d5f4-de04-4b34-882d-6fa19e239fbb"), Type = TextBlockType.Text, Text = "You can take steps to help yourself recover from persistent damage, or an ally can help you, allowing you to attempt an additional flat check before the end of your turn. This is usually an activity requiring 2 actions, and it must be something that would reasonably improve your chances (as determined by the GM). For example, you might try to smother a flame or wash off acid. This allows you to attempt an extra flat check immediately, but only once per round." };
            yield return new TextBlock { Id = Guid.Parse("8347426a-0c25-446e-9ac0-f06ecbd51d73"), Type = TextBlockType.Text, Text = "The GM decides how your help works, using the following examples as guidelines when there's not a specific action that applies." };
            yield return new TextBlock { Id = Guid.Parse("5fdc64fc-6041-4ab6-aa77-57004d59ac56"), Type = TextBlockType.Enumeration, Text = "The action to help might require a skill check or another roll to determine its effectiveness." };
            yield return new TextBlock { Id = Guid.Parse("5732280a-9ddf-402f-a46b-c2aa85c5ec3e"), Type = TextBlockType.Enumeration, Text = "Reduce the DC of the flat check to 10 for a particularly appropriate type of help, such as dousing you in water to put out flames." };
            yield return new TextBlock { Id = Guid.Parse("0219a437-77c5-4ecb-a687-b4d22f0b325b"), Type = TextBlockType.Enumeration, Text = "Automatically end the condition due to the type of help, such as healing that restores you to your maximum HP to end persistent bleed damage, or submerging yourself in a lake to end persistent fire damage." };
            yield return new TextBlock { Id = Guid.Parse("1d39c09f-0f28-41d5-a6d2-bba9edaca845"), Type = TextBlockType.Enumeration, Text = "Alter the number of actions required to help you if the means the helper uses are especially efficient or remarkably inefficient." };
            yield return new TextBlock { Id = Guid.Parse("68a8b2ab-8c1b-4999-8c98-95e27153be58"), Type = TextBlockType.Title, Text = "Immunities, Resistances, And Weaknesses" };
            yield return new TextBlock { Id = Guid.Parse("efd34683-7804-41ff-9901-17a9c3330359"), Type = TextBlockType.Text, Text = "Immunities, resistances, and weaknesses all apply to persistent damage. If an effect deals initial damage in addition to persistent damage, apply immunities, resistances, and weaknesses separately to the initial damage and to the persistent damage. Usually, if an effect negates the initial damage, it also negates the persistent damage, such as with a slashing weapon that also deals persistent bleed damage because it cut you. The GM might rule otherwise in some situations." };
            yield return new TextBlock { Id = Guid.Parse("15d4070a-18c0-458d-a6be-3749a7a35b4d"), Type = TextBlockType.Title, Text = "Multiple Persistent Damage Conditions" };
            yield return new TextBlock { Id = Guid.Parse("2dd9a40b-b519-49b6-b860-1a2a8c89345f"), Type = TextBlockType.Text, Text = "You can be simultaneously affected by multiple persistent damage conditions so long as they have different damage types. If you would gain more than one persistent damage condition with the same damage type, the higher amount of damage overrides the lower amount. The damage you take from persistent damage occurs all at once, so if something triggers when you take damage, it triggers only once; for example, if you're dying with several types of persistent damage, the persistent damage increases your dying condition only once." };
        }*/
    }
}
